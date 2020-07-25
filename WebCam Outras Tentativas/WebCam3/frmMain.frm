VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Powered by Planetcodes.blogspot.com"
   ClientHeight    =   6540
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7590
   LinkTopic       =   "Form1"
   ScaleHeight     =   6540
   ScaleWidth      =   7590
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000009&
      Height          =   6015
      Left            =   0
      ScaleHeight     =   5955
      ScaleWidth      =   7515
      TabIndex        =   2
      Top             =   0
      Width           =   7575
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Save Picture to folder Picture"
      Height          =   375
      Left            =   1680
      TabIndex        =   1
      Top             =   6120
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Snapshot"
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   6120
      Width           =   1575
   End
End
Attribute VB_Name = "frmMain"
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

Private Sub Command1_Click()
Set frmPicture.myPicture = Picture1
frmPicture.Show vbModal
End Sub

Private Sub Command2_Click()
    SavePicture Picture1.Picture, App.Path & "\Picture\" & "Snapshot1.jpg"
    
    MsgBox "Check you picture inside the folder Picture", vbInformation, "Powered By: www.planetcodes.blogspot.com"
End Sub

