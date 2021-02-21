<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="lblSneakerId" runat="server" Text="Sneaker Id"></asp:Label>
            <asp:TextBox ID="txtSneakerId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSneakerDescription" runat="server" Text="Sneaker Description" width="67px"></asp:Label>
            <asp:TextBox ID="txtSneakerDescription" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSneakerColour" runat="server" Text="Sneaker Colour" width="67px"></asp:Label>
            <asp:TextBox ID="txtSneakerColour" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSneakerSize" runat="server" Text="Sneaker Size" width="67px"></asp:Label>
            <asp:TextBox ID="txtSneakerSize" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="67px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
        
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
