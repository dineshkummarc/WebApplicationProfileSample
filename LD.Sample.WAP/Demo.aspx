<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="LD.Sample.WAP.Demo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
</head>
<body>
   <form id="form1" runat="server">
      <div>
         <h1>
            Profile Demo</h1>
         <asp:Panel ID="pnlStart" runat="server">
            <p>
               Indicate the user name of the user you want to display or edit profile properties for in the textbox.<br />
               If the user does not exist, an empty profile will be shown. If you edit and then save this profile, the user will be created
               automatically.</p>
            <p>
               If you want to display or edit profile properties for the <strong>currently logged-on user</strong>, leave the textbox blank.
            </p>
            <asp:TextBox ID="txtUserName" runat="server" />&nbsp;
            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />
         </asp:Panel>
         <h2>
            <asp:Literal ID="litUserTitle" runat="server" /></h2>
         <asp:Panel ID="pnlDisplayValues" runat="server" Visible="false">
            <h3>
               Personal</h3>
            <p>
               First Name:
               <asp:Literal ID="litFirstName" runat="server" />
            </p>
            <p>
               Last Name:
               <asp:Literal ID="litLastName" runat="server" />
            </p>
            <p>
               Date of Birth:
               <asp:Literal ID="litDateOfBirth" runat="server" />
            </p>
            <p>
               Gender:
               <asp:Literal ID="litGender" runat="server" />
            </p>
            <h3>
               Preferences</h3>
            <p>
               Time Zone:
               <asp:Literal ID="litTimeZone" runat="server" />
            </p>
            <p>
               Culture:
               <asp:Literal ID="litCulture" runat="server" />
            </p>
            <asp:Button ID="btnEdit" runat="server" Text="Edit Profile" OnClick="btnEdit_Click" />&nbsp;&nbsp;
            <asp:Button ID="btnCancelDisplay" runat="server" Text="Choose Another Profile" OnClick="btnCancelDisplay_Click" />
         </asp:Panel>
         <asp:Panel ID="pnlSetValues" runat="server" Visible="false">
            <p>
               If the user already exists, some profile properties may already be displayed.<br />
               Go ahead and edit the ones you want, then click Save.
            </p>
            <h3>
               Personal
            </h3>
            <p>
               <asp:Label ID="lblFirstName" runat="server" AssociatedControlID="txtFirstName" Text="First Name:" /><br />
               <asp:TextBox ID="txtFirstName" runat="server" />
            </p>
            <p>
               <asp:Label ID="lblLastName" runat="server" AssociatedControlID="txtLastName" Text="Last Name:" /><br />
               <asp:TextBox ID="txtLastName" runat="server" />
            </p>
            <p>
               <asp:Label ID="lblDateOfBirth" runat="server" AssociatedControlID="txtDateOfBirth" Text="Date of Birth:" /><br />
               <asp:TextBox ID="txtDateOfBirth" runat="server" />
            </p>
            <p>
               <asp:Label ID="lblGender" runat="server" AssociatedControlID="ddlGender" Text="Gender" /><br />
               <asp:DropDownList ID="ddlGender" runat="server" />
            </p>
            <h3>
               Preferences</h3>
            <p>
               <asp:Label ID="lblTimeZone" runat="server" AssociatedControlID="ddlTimeZones" Text="Time Zone:" /><br />
               <asp:DropDownList ID="ddlTimeZones" runat="server" />
            </p>
            <p>
               <asp:Label ID="lblCulture" runat="server" AssociatedControlID="ddlCultures" Text="Culture:" /><br />
               <asp:DropDownList ID="ddlCultures" runat="server" />
            </p>
            <p>
               <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />&nbsp;&nbsp;
               <asp:Button ID="btnCancelEdit" runat="server" Text="Cancel" OnClick="btnCancelEdit_Click" />
            </p>
         </asp:Panel>
      </div>
   </form>
</body>
</html>
