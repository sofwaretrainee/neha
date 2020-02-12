<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="CurdOperation.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>  
          <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Upgrade.aspx" style="margin-left:750px;">Register</asp:LinkButton>
            <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" >  
               
                <Columns>  
                    <%-- <asp:TemplateField>  
                        <ItemTemplate>  
                               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>                         
                        </ItemTemplate>  
                    </asp:TemplateField>  --%>
                    <asp:BoundField DataField="userId"  />  
                    <asp:BoundField DataField="First_name" HeaderText="First_Name" />  
                    <asp:BoundField DataField="Last_name" HeaderText="Last_Name" />  
                    <asp:BoundField DataField="mailId" HeaderText="mailId" />  
                    <asp:BoundField DataField="Password" HeaderText="Password" />  
                     <asp:BoundField DataField="Gender" HeaderText="Gender" />  
                    <asp:BoundField DataField="dateOfBirth" HeaderText="dateofBirth" />  
                    <asp:BoundField DataField="Mobile" HeaderText="Mobile" />  
                    <asp:BoundField DataField="Address" HeaderText="Address" />  
                    
                    <asp:TemplateField>  
                        <ItemTemplate>  
                            <asp:Button ID="btnEdit" runat="server" Width="60" Text="Edit" CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />  
                            <asp:Button ID="Button1" runat="server" Width="60" Text="Delete" CommandName="DeleteButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />  
                        </ItemTemplate>  
                    </asp:TemplateField>  
                </Columns>  
            </asp:GridView>  
        </div>  
    </form>
</body>
</html>
