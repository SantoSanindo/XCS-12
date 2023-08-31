Option Explicit On
Imports System.Runtime.InteropServices
Module modZebraUSB
    Public sWrittendata As String

    Public Structure DOCINFO
        <MarshalAs(UnmanagedType.LPStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPStr)> Public pDataType As String
    End Structure

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function OpenPrinter(ByVal pPrinterName As String, ByRef hPrinter As IntPtr, ByVal pDefault As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Integer, ByRef pDocInfo As DOCINFO) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function WritePrinter(ByVal hPrinter As IntPtr, ByRef pBuf As IntPtr, ByVal cdBuf As Integer, ByRef pcWritten As Integer) As Boolean
    End Function

    <DllImport("winspool.drv", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Function ReadPrinter(ByVal hPrinter As IntPtr, ByRef pBuf As IntPtr, ByVal cdBuf As Integer, ByRef pcRead As Integer) As Boolean
    End Function
End Module
