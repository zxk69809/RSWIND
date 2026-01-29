Imports System
Imports System.ComponentModel
Imports System.Net
Imports System.Net.Mail
Imports System.Runtime.CompilerServices
Imports System.Web
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Class SendMail
		Public Overridable Property EmailServer As SmtpClient
			Get
				Return Me._EmailServer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SmtpClient)
				Dim value2 As SendCompletedEventHandler = AddressOf Me.EmailServer_SendCompleted
				If Me._EmailServer IsNot Nothing Then
					RemoveHandler Me._EmailServer.SendCompleted, value2
				End If
				Me._EmailServer = value
				If Me._EmailServer IsNot Nothing Then
					AddHandler Me._EmailServer.SendCompleted, value2
				End If
			End Set
		End Property

		Public Sub Send(args As String())
			Try
				Try
					Dim mailMessage As MailMessage = New MailMessage(args(2), args(1), args(3), args(4))
					Dim mailMessage2 As MailMessage = mailMessage
					Try
						If Operators.CompareString(args(5), "", False) <> 0 Then
							Dim c As Char = ","c
							For Each fileName As String In args(5).Split(New Char() { c })
								Dim item As Attachment = New Attachment(fileName)
								mailMessage2.Attachments.Add(item)
							Next
						End If
					Catch ex As Exception
					End Try
					Try
						Me.EmailServer = New SmtpClient(args(0))
						Me.EmailServer.Credentials = New NetworkCredential(args(8), args(9))
						Me.EmailServer.Port = 587
						Me.EmailServer.SendAsync(mailMessage, Me)
					Catch ex2 As HttpException
					End Try
				Catch ex3 As IndexOutOfRangeException
				End Try
			Catch ex4 As Exception
			End Try
		End Sub

		Private Sub EmailServer_SendCompleted(sender As Object, e As AsyncCompletedEventArgs)
			If e.[Error] Is Nothing Then
				If e.Cancelled Then
					MessageBox.Show("Email Cancelled", "Email Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					MessageBox.Show(String.Concat(New String() { "Email Sent" }), "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Else
				MessageBox.Show(e.[Error].ToString(), "Error Sending Email", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		<AccessedThroughProperty("EmailServer")>
		Private _EmailServer As SmtpClient
	End Class
End Namespace
