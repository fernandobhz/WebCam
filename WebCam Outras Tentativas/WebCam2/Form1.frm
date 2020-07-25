VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5355
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10155
   LinkTopic       =   "Form1"
   ScaleHeight     =   5355
   ScaleWidth      =   10155
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command 
      Height          =   495
      Left            =   7440
      TabIndex        =   4
      Top             =   4680
      Width           =   855
   End
   Begin VB.PictureBox Picture1 
      Height          =   3855
      Left            =   240
      ScaleHeight     =   3795
      ScaleWidth      =   9555
      TabIndex        =   3
      Top             =   240
      Width           =   9615
   End
   Begin VB.CommandButton cmdVideoFormat 
      Caption         =   "Processa"
      Height          =   735
      Left            =   2760
      TabIndex        =   2
      Top             =   4320
      Width           =   4215
   End
   Begin VB.CommandButton cmdCapture 
      Caption         =   "Capture"
      Height          =   1095
      Left            =   120
      TabIndex        =   1
      Top             =   4200
      Width           =   2175
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Height          =   615
      Left            =   8520
      TabIndex        =   0
      Top             =   4680
      Width           =   1575
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'This program check whether webcam is available or not
' if available then capture and displays in picture box

'Created by Dixanta Bahadur Shrestha
'Created Date: 12-March-2006

'Programmer does not garuntees if  not functions well

Dim hwdc As Long
Dim startcap As Boolean
Private Sub cmdCapture_Click()
Dim temp As Long
  'hwdc = capCreateCaptureWindow("Dixanta Vision System", ws_child Or ws_visible, 0, 0, 320, 240, Picture1.hWnd, 0)
  hwdc = capCreateCaptureWindow("captura Janela", 0, 0, 0, 320, 240, Me.Picture1.hWnd, 0)
    
  If (hwdc <> 0) Then
    temp = SendMessage(hwdc, wm_cap_driver_connect, 0, 0)
    temp = SendMessage(hwdc, wm_cap_set_preview, 1, 0)
    temp = SendMessage(hwdc, WM_CAP_SET_PREVIEWRATE, 30, 0)
    startcap = True
    Else
    MsgBox ("No Webcam found")
  End If
End Sub

Private Sub cmdClose_Click()
Dim temp As Long
If startcap = True Then
temp = SendMessage(hwdc, WM_CAP_DRIVER_DISCONNECT, 0&, 0&)
startcap = False
End If
End Sub

Private Sub cmdVideoFormat_Click()
 Dim temp As Long
 If startcap = True Then
  temp = SendMessage(hwdc, WM_CAP_DLG_VIDEOFORMAT, 0&, 0&)
End If
End Sub

Private Sub Command_Click()
  Clipboard.Clear
   SendMessage hwdc, WM_CAP_GRAB_FRAME, 0, 0
   SendMessage hwdc, WM_CAP_EDIT_COPY, 0, 0
   Picture1.Picture = Clipboard.GetData
End Sub
