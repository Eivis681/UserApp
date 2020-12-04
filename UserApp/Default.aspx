<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserApp._Default" %>

<asp:Content ID="RegisterContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="padding-top:20px; width:300px;">

        <div>
            <asp:Label ID="Label3" runat="server" Width="100%" Text="Vardas:"></asp:Label>
            <asp:TextBox ID="nameField" runat="server" Width="100%" Text=""></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label4" runat="server" Width="100%" Text="Pavarde:"></asp:Label>
            <asp:TextBox ID="surnameField" runat="server" Width="100%" Text=""></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label7" runat="server" Width="100%" Text="Asmens kodas:"></asp:Label>
            <asp:TextBox ID="asmensKodoFiels" runat="server" Width="100%" Text=""></asp:TextBox>
        </div>

         <div>  
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Vyras" GroupName="gender" />  
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Moteris" GroupName="gender" />  
        </div>  

        <div>
            <asp:Label ID="Label8" runat="server" Width="100%" Text="Adresas:"></asp:Label>
            <asp:TextBox ID="addressField" runat="server" Width="100%" Text=""></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label9" runat="server" Width="100%" Text="Telefono numeris"></asp:Label>
            <asp:TextBox ID="phoneField" runat="server" Width="100%" Text=""></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="Label6" runat="server" Width="100%" Text="Studiju programa:"></asp:Label>
            <asp:DropDownList ID="studijuField" runat="server" Width="100%">
                <asp:ListItem Value="0" disabled>Studiju programos:</asp:ListItem>
                <asp:ListItem Value="1">Elektronikos inžinerija</asp:ListItem>
                <asp:ListItem Value="2">Informacijos sistemos</asp:ListItem>
                <asp:ListItem Value="3">Kompiuterių inžinerija</asp:ListItem>
                <asp:ListItem Value="4">Kompiuterių sistemos</asp:ListItem>
                <asp:ListItem Value="5">Programų sistemos</asp:ListItem>
                <asp:ListItem Value="6">Telekomunikacijų sistemos</asp:ListItem>
            </asp:DropDownList>
            </div>
        <div>
            <asp:Label ID="Label10" runat="server" Width="100%" Text="Studiju forma:"></asp:Label>
            <asp:DropDownList ID="formaField" runat="server" Width="100%">
                <asp:ListItem Value="0" disabled>Studiju formos:</asp:ListItem>
                <asp:ListItem Value="1">Nuolatines </asp:ListItem>
                <asp:ListItem Value="2">Nuolatines sesijines</asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <div style="text-align:center;">
            <asp:Label ID="errorLabel" runat="server" ForeColor="Red" Width="100%" Text=""></asp:Label>
        </div>
        <div style="padding-top: 10px;">
            <asp:Button ID="registerButton" Width="100%" runat="server" OnClick="registerButton_Click" Text="Pateikti" />
        </div>
    </div>
</asp:Content>