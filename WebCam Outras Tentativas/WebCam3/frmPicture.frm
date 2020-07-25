VERSION 5.00
Begin VB.Form frmPicture 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Picture-Picture"
   ClientHeight    =   6675
   ClientLeft      =   45
   ClientTop       =   345
   ClientWidth     =   7785
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6675
   ScaleWidth      =   7785
   StartUpPosition =   1  'CenterOwner
   Begin VB.CommandButton cmdTake 
      Caption         =   "Take Picture (SMILE)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Top             =   6120
      Width           =   7575
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000009&
      Height          =   6015
      Left            =   120
      ScaleHeight     =   5955
      ScaleWidth      =   7515
      TabIndex        =   0
      Top             =   120
      Width           =   7575
   End
End
Attribute VB_Name = "frmPicture"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Powered By: www.planetcodes.blogspot.com
'Powered By: www.planetcodes.blogspot.com
'Powered By: www.planetcodes.blogspot.com
'Powered By: www.planetcodes.blogspot.com
'Powered By: www.planetcodes.blogspot.com
'Powered By: www.planetcodes.blogspot.com

Public myPicture As PictureBox
Dim StartCap As Boolean, hwdc
Private Sub cmdTake_Click()
    SendMessage hwdc, WM_CAP_GET_FRAME, 0, 0
    SendMessage hwdc, WM_CAP_COPY, 0, 0
    myPicture.Picture = Clipboard.GetData
    Unload Me
End Sub
Function startcamera()

'''''START TAKING VIEWS******************************************

Dim temp As Long

  hwdc = capCreateCaptureWindow("www.planetcodes.blogspot.com", ws_child Or ws_visible, 0, 0, 500, 400, Picture1.hWnd, 0)
  If (hwdc <> 0) Then
    temp = SendMessage(hwdc, wm_cap_driver_connect, 0, 0)
    temp = SendMessage(hwdc, wm_cap_set_preview, 1, 0)
    temp = SendMessage(hwdc, WM_CAP_SET_PREVIEWRATE, 30, 0)
    StartCap = True
  Else
    MsgBox ("No Webcam found")
  End If
  
End Function

Private Sub Form_Load()
startcamera
End Sub
