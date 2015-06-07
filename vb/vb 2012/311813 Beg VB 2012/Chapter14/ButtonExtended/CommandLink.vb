Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.ComponentModel

<ToolboxBitmap(GetType(System.Windows.Forms.Button))> _
Public Class CommandLink
    Inherits Button

    'Private variables and objects
    Private blnUACShield As Boolean = False
    Private strSupplementalExplanation As String = String.Empty
    Private objBitmap As Bitmap

    'Private constants
    Private Const BS_COMMANDLINK As Integer = 14
    Private Const BCM_SETNOTE As Integer = 5641
    Private Const BCM_SETSHIELD As Integer = 5644
    Private Const BM_SETIMAGE As Integer = 247

    'SendMessage API
    <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr,
    ByVal msg As Integer, ByVal wParam As Integer,
    ByVal lParam As String) As Integer
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr,
    ByVal msg As Integer, ByVal wParam As Integer,
    ByVal lParam As Boolean) As Integer
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr,
    ByVal msg As Integer, ByVal wParam As Integer,
    ByVal lParam As Integer) As Integer
    End Function

    Public Sub New()
        'Set the FlatStyle property
        Me.FlatStyle = FlatStyle.System
    End Sub

    Protected Overrides ReadOnly Property DefaultSize() _
    As System.Drawing.Size
        Get
            'Set the new default size of the control
            'when placed on a form
            Return New Size(270, 60)
        End Get
    End Property

    Protected Overrides ReadOnly Property CreateParams() _
    As System.Windows.Forms.CreateParams
        Get
            'Set the style of the Button to CommandLink
            Dim objCreateParams As CreateParams = MyBase.CreateParams
            objCreateParams.Style = objCreateParams.Style Or BS_COMMANDLINK
            Return objCreateParams
        End Get
    End Property

    <Category("Appearance"), _
Description("Indicates if the UAC shield icon will be displayed " &
"on the control."), _
DefaultValue(False)> _
    Public Property UACShield() As Boolean
        Get
            Return blnUACShield
        End Get
        Set(ByVal value As Boolean)
            blnUACShield = value
            'Add the shield icon to the control
            SendMessage(Me.Handle, BCM_SETSHIELD, 0, blnUACShield)
        End Set
    End Property

    <Category("Appearance"), _
Description("The optional supplemental explanation for the control."),
DefaultValue("")> _
    Public Property SupplementalExplanation() As String
        Get
            Return strSupplementalExplanation
        End Get
        Set(ByVal value As String)
            strSupplementalExplanation = value
            'Add the supplemental explanation to the control
            SendMessage(Me.Handle, BCM_SETNOTE, 0, value)
        End Set
    End Property

    <Category("Appearance"), _
Description("The image that will be displayed on the control."),
DefaultValue(GetType(Nullable))> _
    Public Shadows Property Image() As Bitmap
        Get
            Return objBitmap
        End Get
        Set(ByVal value As Bitmap)
            objBitmap = value
            UACShield = False
            If value IsNot Nothing Then
                'Add the image to the control instead of using the default image
                SendMessage(Me.Handle, BM_SETIMAGE, 1, objBitmap.GetHicon.ToInt32)
            End If
        End Set
    End Property

End Class
