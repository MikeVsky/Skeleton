<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" Text="CustomerId"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="margin-bottom: 2px" Width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name" width="72px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" Text="Last Name" width="72px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email" width="72px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStreet" runat="server" Text="Street" width="72px"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblFlat" runat="server" Text="Flat" width="72px"></asp:Label>
            <asp:TextBox ID="txtFlat" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCity" runat="server" Text="City" width="72px"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblPostcode" runat="server" Text="Postcode" width="72px"></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCountry" runat="server" Text="Country" width="72px"></asp:Label>
            <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded" width="72px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
