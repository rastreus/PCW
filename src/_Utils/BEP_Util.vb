Imports System.Text.RegularExpressions

''' <summary>
''' Global Back End Processor class which handles common, utility tasks.
''' </summary>
''' <remarks></remarks>
Public Class BEP_Util
#Region "Utility Subroutines"
	''' <summary>
	''' Invalid if "0" or Not 1 or more digit.
	''' </summary>
	''' <param name="inputString"></param>
	''' <returns>The validity of the input String.</returns>
	''' <remarks>Don't like that it does the Short Parse.</remarks>
	Public Shared Function invalidNum(ByVal inputString As String) As Boolean
		Dim invalid As Boolean = False
		Dim inputInt As Short
		Dim RegexObj As Regex = New Regex("^\d+$")

		Try
			inputInt = Short.Parse(inputString)
			If (inputInt = 0) Or Not RegexObj.IsMatch(inputString) Then
				invalid = True
			End If
		Catch ex As Exception
			invalid = True
		End Try

		Return invalid
	End Function
#End Region
End Class
