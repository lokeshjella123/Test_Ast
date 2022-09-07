Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim astlic As New AstroSubscribeDLL.AstroLicense


        'txtDeviceID.Text = astlic.DeviceID
        Dim did As String = astlic.DeviceID
        Dim subs As New AstroSubscribeDLL.TrialLicense
        'txtSerialKey.Text = subs.SerialKeySubscriptionTrial
        Dim sk As String = subs.SerialKeySubscriptionTrial
    End Sub
End Class