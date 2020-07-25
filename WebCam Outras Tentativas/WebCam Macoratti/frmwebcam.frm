VERSION 5.00
Begin VB.Form frmwebcam 
   BackColor       =   &H008080FF&
   Caption         =   "Capturando Imagens da Web Cam"
   ClientHeight    =   4470
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6855
   LinkTopic       =   "Form1"
   ScaleHeight     =   4470
   ScaleWidth      =   6855
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdAtivaVideoContinuo 
      BackColor       =   &H0000C0C0&
      Caption         =   "Ativar Video Contínuo"
      Height          =   615
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   1680
      Width           =   1335
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   100
      Left            =   5520
      Top             =   3840
   End
   Begin VB.CommandButton cmdSair 
      BackColor       =   &H00FF8080&
      Caption         =   "Sair"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   3120
      Width           =   1335
   End
   Begin VB.CommandButton cmdEncerraWebCam 
      BackColor       =   &H0080C0FF&
      Caption         =   "Encerra Web Cam"
      Height          =   615
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   960
      Width           =   1335
   End
   Begin VB.CommandButton cmdIniciaWebCam 
      BackColor       =   &H0080C0FF&
      Caption         =   "Inicia Web Cam"
      Height          =   615
      Left            =   5400
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   240
      Width           =   1335
   End
   Begin VB.CommandButton cmdCapturaImagem 
      BackColor       =   &H0080C0FF&
      Caption         =   "Capturar Imagem da Web Cam"
      Height          =   495
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   3840
      Width           =   5055
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00E0E0E0&
      Height          =   3495
      Left            =   240
      ScaleHeight     =   3435
      ScaleWidth      =   4995
      TabIndex        =   0
      Top             =   240
      Width           =   5055
   End
End
Attribute VB_Name = "frmwebcam"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function capCreateCaptureWindow Lib "avicap32.dll" Alias "capCreateCaptureWindowA" (ByVal lpszWindowName As String, ByVal dwStyle As Long, ByVal X As Long, ByVal Y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal hwndParent As Long, ByVal nID As Long) As Long
Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
Private Declare Function ReleaseCapture Lib "USER32" () As Long
Private Const WM_CAP_DRIVER_CONNECT As Long = 1034
Private Const WM_CAP_DRIVER_DISCONNECT As Long = 1035
Private Const WM_CAP_GRAB_FRAME As Long = 1084
Private Const WM_CAP_EDIT_COPY As Long = 1054
Private Const WM_CAP_DLG_VIDEOFORMAT As Long = 1065
Private Const WM_CAP_DLG_VIDEOSOURCE As Long = 1066
Private Const WM_CLOSE = &H10
Private mCapHwnd As Long
Private Sub cmdAtivaVideoContinuo_Click()
 Timer1.Enabled = True
 Timer1.Interval = 50
End Sub
Private Sub cmdCapturaImagem_Click()
'Captura a imagem atual
   Clipboard.Clear
   SendMessage mCapHwnd, WM_CAP_GRAB_FRAME, 0, 0
   SendMessage mCapHwnd, WM_CAP_EDIT_COPY, 0, 0
   Picture1.Picture = Clipboard.GetData
End Sub
Private Sub cmdEncerraWebCam_Click()
 'Desliga a câmera
   SendMessage mCapHwnd, WM_CAP_DRIVER_DISCONNECT, 0, 0
End Sub
Private Sub cmdIniciaWebCam_Click()
'Inicia a câmera
   mCapHwnd = capCreateCaptureWindow("captura Janela", 0, 0, 0, 320, 240, Me.hwnd, 0)
   SendMessage mCapHwnd, WM_CAP_DRIVER_CONNECT, 0, 0
End Sub
Private Sub cmdSair_Click()
End
End Sub
Private Sub Form_Terminate()
   'Desliga a câmera
   SendMessage mCapHwnd, WM_CAP_DRIVER_DISCONNECT, 0, 0
End Sub
Private Sub Timer1_Timer()
'Exibe imagem continua no pictubox
   Clipboard.Clear
   SendMessage mCapHwnd, WM_CAP_GRAB_FRAME, 0, 0
   SendMessage mCapHwnd, WM_CAP_EDIT_COPY, 0, 0
   Picture1.Picture = Clipboard.GetData
   DoEvents
End Sub
