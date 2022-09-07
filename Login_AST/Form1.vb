Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim astlic As New AstroSubscribeDLL.AstroLicense


        'txtDeviceID.Text = astlic.DeviceID
        Dim did As String = astlic.DeviceID
        Dim subs As New AstroSubscribeDLL.TrialLicense
        'txtSerialKey.Text = subs.SerialKeySubscriptionTrial
        Dim sk As String = subs.SerialKeySubscriptionTrial

        Dim a As New AstroSubscribeDLL.YourSecondClass
        Dim hash As String = a.GetHashCode
        Dim b As New AstroSubscribeDLL.AstroLicense
        Dim isvalid As String = b.IsValid

        Dim d As New AstroSubscribeDLL.FormActivation



        'Dim ec As New AstroSubscribeDLL.FormSubscription
        ' ec.

        Dim f As New AstroSubscribeDLL.FullLicense

        Dim myLib As New AstroSubscribeDLL.WriteYourClass

        Dim result = myLib.numbersquare(10)

        MsgBox(String.Format("Result: {0}", result))
    End Sub
End Class
