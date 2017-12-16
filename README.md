### RFID射频识别技术课程设计--ETC不停车收费系统

该项目为ETC不停车收费系统客户端。
开发工具:Visual Studio 2017
使用的RFID阅读器:  **圆志RW163AC** (125K 阅读器)

该设备比较简单，只支持125K电子标签的读取。于是，用SerialPort进行读取。具体实现代码在RFID_EX_ETC_Client\MainForm.cs中。可根据注释自行参悟。
