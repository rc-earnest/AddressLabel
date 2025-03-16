'Rudy Earnest
'RCET 2265
'Spring 2025
'Address Label Program
' git link
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddressLabelForm

    Private Sub AddressLabelorm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(FirstNameTextBox, "Enter first name")
        ToolTip1.SetToolTip(LastNameTextBox, "Enter last name")
        ToolTip1.SetToolTip(StreetAddressTextBox, "Enter street address")
        ToolTip1.SetToolTip(CityTextBox, "Enter city")
        ToolTip1.SetToolTip(StateTextBox, "Enter state")
        ToolTip1.SetToolTip(ZipTextBox, "Enter zip code")
        ToolTip1.SetToolTip(DisplayButton, "Display the formatted address")
        ToolTip1.SetToolTip(ClearButton, "Clear all input fields")
        ToolTip1.SetToolTip(ExitButton, "Exit the application")
        SetDefaults()
    End Sub
    Sub SetDefaults()
        FirstNameTextBox.Focus()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        DisplayLabel.Text = ""
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim fullName As String = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}"
        Dim formattedAddress As String = $"{fullName}{vbCrLf}{StreetAddressTextBox.Text}{vbCrLf}{CityTextBox.Text}, {StateTextBox.Text} {ZipTextBox.Text}"
        DisplayLabel.Text = formattedAddress
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
