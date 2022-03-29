using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Serial Port
using System;
using System.IO.Ports;
using System.Threading;


public class SerialPortDataReceiver : MonoBehaviour
{
    public string portName;
    public int baudRate;

    public SerialPort serialPort;

    public bool useOutlierDetection;

    int message;
    int horizontalData;
    int verticalData;

    int[] buffHorizontalData = new int[4];
    int[] buffVerticalData = new int[4];

    Thread readThread;

    void Start()
    {
        readThread = new Thread(Read);

        string[] ports = SerialPort.GetPortNames();

        if (ports.Length == 0)
        {
            Debug.LogError("No Paddle connected");
        }
        else
        {
            serialPort = new SerialPort(ports[0], 19200, Parity.None, 8, StopBits.One);

            serialPort.Close();
            serialPort.ReadTimeout = 50;
            serialPort.RtsEnable = true;
            serialPort.DtrEnable = true;

            serialPort.Open();
            readThread.Start();
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    public float getPaddleDateHorizontal()
    {
        return horizontalData;
    }

    public float getPaddleDateVertical()
    {
        return verticalData;
    }

    void Read()
    {

        int byte00 = -1;
        int byte01 = -1;
        int byte10 = -1;
        int byte11 = -1;

        int buffCount1 = 0;
        int buffCount2 = 0;

        while (true)
        {
            try
            {

                int byteMessage = serialPort.ReadByte();
                Debug.Log(byteMessage);

                //00
                if (byteMessage < 64)
                {
                    byte00 = byteMessage;
                }
                //01
                else if (byteMessage < 128)
                {
                    byte01 = byteMessage - 64;
                }
                //10
                else if (byteMessage < 192)
                {
                    byte10 = byteMessage - 128;
                }
                //11
                else
                {
                    byte11 = byteMessage - 192;
                }


                if (byte00 != -1 && byte01 != -1)
                {
                    byte00 = byte00 << 6;
                    int horizontalData = byte00 + byte01;
                    byte00 = -1; byte01 = -1;

                    if (useOutlierDetection)
                    {
                        buffHorizontalData[buffCount1] = horizontalData;
                        Debug.Log(horizontalData);

                        buffCount2++;
                        if (buffCount1 > buffHorizontalData.Length)
                        {
                            buffCount1 = 0;
                            float mean = 0;
                            for (int i = 0; i < buffHorizontalData.Length; i++)
                            {
                                mean += buffHorizontalData[i];
                                if (i == buffHorizontalData.Length)
                                {
                                    mean /= buffHorizontalData.Length;

                                    for (int j = 0; j < buffHorizontalData.Length; j++)
                                    {
                                        if (buffHorizontalData[j] < 1.1 * mean)
                                        {
                                            horizontalData = buffHorizontalData[j];
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                    

                if (byte10 != -1 && byte11 != -1)
                {
                    byte10 = byte10 << 6;
                    verticalData = byte10 + byte11;
                    byte10 = -1; byte11 = -1;

                    //outlier detection
                    if (useOutlierDetection)
                    {
                        buffVerticalData[buffCount2] = verticalData;
                        buffCount2++;
                        if (buffCount2 > buffVerticalData.Length)
                        {
                            buffCount2 = 0;
                            float mean = 0;
                            for (int i = 0; i < buffVerticalData.Length; i++)
                            {
                                mean += buffVerticalData[i];
                                if (i == buffVerticalData.Length)
                                {
                                    mean /= buffVerticalData.Length;

                                    for (int j = 0; j < buffVerticalData.Length; j++)
                                    {
                                        if (buffVerticalData[j] < 1.1 * mean)
                                        {
                                            verticalData = buffVerticalData[j];
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Debug.Log(verticalData);
                }
            }
            catch (TimeoutException)
            {
                Debug.Log("TimeOut");
            }
        }
    }
}
