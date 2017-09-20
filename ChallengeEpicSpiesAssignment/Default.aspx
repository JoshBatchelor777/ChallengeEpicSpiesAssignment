<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family: Arial, Helvetica, sans-serif">
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="189px" ImageUrl="epic-spies-logo.jpg" Width="149px" />
    
        <br />
        <h2>Spy New Assignment Form</h2>
        <br />
        <br />
        Spy Code Name:
        <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:
        <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment<br />
        <asp:Calendar ID="endOfOldCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Start Date of New Assignment<br />
        <asp:Calendar ID="newCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Project End Date of New Assignment<br />
        <asp:Calendar ID="endOfNewCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
