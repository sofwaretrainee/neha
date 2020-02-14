<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_Page.aspx.cs" Inherits="Student_Register.Register_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container {
            border: 1px solid black;
            width: 350px;
            height: 400px;
            margin-left: 500px;
            margin-top: 100px;
        }

        .StudentFname {
            padding-left: 40px;
            padding-top: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container StudentFname ">
            <asp:Label runat="server" Text="studentId"></asp:Label>
            <asp:TextBox ID="txtstudentId" runat="server" Width="140" Style="margin-left: 19px" />
            <div>
                <asp:Label runat="server" Text="studentFirst_name"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" Width="140" Style="margin-left: 19px" />
            </div>
            <br />
            <div>
                <asp:Label runat="server" Text="studentLast_name"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" Width="140" Style="margin-left: 19px" />
            </div>
            <br />
            <div>
                <asp:Label ID="Label1" runat="server" Text="student_gender"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="140" Style="margin-left: 150px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>FeMale</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <br />
            <div>
                <asp:Label runat="server" Text="student_Dob"></asp:Label>
                <asp:TextBox ID="txtDob" runat="server" Width="140" type="Date" Style="margin-left: 47px" />
            </div>
            <br />
            <div>
                <asp:Label runat="server" Text="Passsword"></asp:Label>
                <asp:TextBox ID="TextPassword" runat="server" Width="140" MaxLength="10" Style="margin-left: 58px" TextMode="Password" />
            </div>
            <br />
            <div>
                <asp:Label runat="server" Text="student_mobileno"></asp:Label>
                <asp:TextBox ID="txtMblNo" runat="server" Width="140" Style="margin-left: 16px;" MaxLength="10" />
            </div>
            <br />

            <div>
                <asp:Label runat="server" Text="student_address"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" Width="140" Style="margin-left: 26px" />
            </div>
            <br />
            <div style="margin-left: 130px">
                <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                <asp:Button ID="ButtonCancel" runat="server" Text="Cancel"  OnClick="ButtonCancel_Click" Style="margin-left: 13px" />
                 <asp:Button ID="ButtonDelte" runat="server" Text="Delte"  OnClick="ButtonDelte_Click" Style="margin-left: 13px" />
            </div>
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="studentId" DataField="studentId" />
                <asp:BoundField HeaderText="studentFirst_name" DataField="studentFirst_name" />
                <asp:BoundField HeaderText="studentLast_name" DataField="studentLast_name" />
                <asp:BoundField HeaderText="student_gender" DataField="student_gender" />
                <asp:BoundField HeaderText="student_Dob" DataField="student_Dob" />
                <asp:BoundField HeaderText="Passsword" DataField="Passsword" />
                <asp:BoundField HeaderText="student_mobileno" DataField="student_mobileno" />
                 <asp:BoundField HeaderText="student_address" DataField="student_address" />



            </Columns>
        </asp:GridView>
    </form>
</body>
</html>












