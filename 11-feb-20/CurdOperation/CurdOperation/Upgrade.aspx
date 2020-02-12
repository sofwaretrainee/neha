<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upgrade.aspx.cs" Inherits="CurdOperation.Upgrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
             
            background-image:url('https://as2.ftcdn.net/jpg/00/97/18/09/500_F_97180926_Oo2CqFOH5uDqsOJ2scgB9HLhlblcInDX.jpg');
          }
           Button{
               margin-left:20px;
           }
            
           
        
        table{
            margin-left:600px;
            margin-top:100px;
            border:none;
            height:500px;
            width:500px;
            padding-left:100px;
            background-color:gray;
            color:white;
        }
        h1{
            color:red;
        }
        .auto-style1 {
            height: 24px;
        }
        .auto-style2 {
            width: 195px;
        }
        .auto-style3 {
            height: 24px;
            width: 195px;
        }
        </style>
</head>
<body>
     <marquee><h1>Welcome to Our Register Page</h1></marquee>
    <form id="form1" runat="server">
    <div>    
   <table>    
     
       <tr>    
           <td>First_name</td>    
           <td class="auto-style2">    
               <asp:TextBox ID="txtFirstName" runat="server" Width="179px" />    
           </td>    
       </tr> 
       
       <tr>    
           <td>Last_name</td>    
           <td class="auto-style2">    
               <asp:TextBox ID="txtLastname" runat="server" Width="179px"  />    
           </td>    
       </tr> 
           
       <tr>    
           <td>mailId</td>    
           <td class="auto-style2">    
               <asp:TextBox ID="txtmailid" runat="server" Width="178px" />    
           </td>    
       </tr> 
    
       <tr>    
           <td>Password</td>    
           <td class="auto-style2">    
               <asp:TextBox ID="txtPassword" runat="server" Width="176px" />    
           </td>    
       </tr> 
          
       <tr>    
           <td>Gender</td>    
           <td class="auto-style2">    
               <asp:TextBox ID="txtGender" runat="server" Width="177px" />    
           </td>    
       </tr>    
       
        <tr>    
           <td>dateOfBirth</td>    
           <td class="auto-style2">    
               <asp:TextBox ID="txtDob" runat="server" Width="180px" />    
           </td>    
       </tr> 

       <tr>    
           <td class="auto-style1">Mobile</td>    
           <td class="auto-style3">    
               <asp:TextBox ID="txtMobile" runat="server" Width="179px" />    
           </td>    
       </tr> 
     
       <tr>
           <td>Address</td>
           <td class="auto-style2">
               <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="179px" /> 
               </td>
           </tr>  
       <br/>      
       <tr> 
           
           <td align="center">    
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" style="margin-left: 18px" Width="58px" />    
           </td>    
           <td align="center" class="auto-style2">    
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" style="margin-left: 0px" Width="58px" />    
           </td>
           <td align="center">    
               <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" style="margin-left: 12px" />    
           </td>    
       </tr>    
   </table>    
         
</div>    
    </form>
</body>
</html>
