Public Class Principal
    'quitar bloton X
    Dim _enabledCerrar As Boolean = False
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")> _
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Planeacion As New Planeacion
        Me.Hide()
        Planeacion.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MttoCorrectivo As New MttoCorrectivo
        Me.Hide()
        MttoCorrectivo.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = Login.FullName
        Label4.Text = Login.Role
    End Sub
End Class