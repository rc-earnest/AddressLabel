'Rudy Earnest
'RCET 2265
'Spring 2025
'Address Label Program
'https://github.com/rc-earnest/AddressLabel.git
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddressLabelForm
    ''' <summary>
    ''' Activates defaults and tool tips for each item in form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddressLabelorm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'makes a tool tip for each item on the form
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
    ''' <summary>
    ''' Sets the defaults for each item on the form.
    ''' </summary>
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
    ''' <summary>
    ''' Once the "Display" button is clicked it formats the items that are in the text
    ''' boxs to how you would see them on an address label, and then displays it in the output address box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim fullName As String = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}"
        Dim formattedAddress As String = $"{fullName}{vbCrLf}{StreetAddressTextBox.Text}{vbCrLf}{CityTextBox.Text}, {StateTextBox.Text} {ZipTextBox.Text}"
        DisplayLabel.Text = formattedAddress
    End Sub
    ''' <summary>
    ''' "Clears" the text boxes once the clear button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub
    ''' <summary>
    ''' Exits the form once the exit button was pressed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
