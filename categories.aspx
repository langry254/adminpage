<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="categories.aspx.cs" Inherits="adminpage.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="dash">
    <div class="passbox">
        <h2>Create category</h2>
        
        <div class="passcards">            
            <asp:Label ID="Label1" runat="server" Text="Category Name" ></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" class="inputs" >
                <asp:ListItem>Vegetables</asp:ListItem>
                <asp:ListItem>Fruits</asp:ListItem>
            </asp:DropDownList> 
        </div>

         <div class="passcards">
            <asp:Label ID="Label2" runat="server" Text="Product name" ></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" class="inputs" placeholder="product name"></asp:TextBox><br />
         </div>

        <div class="passcards">
            <asp:Label ID="Label4" runat="server" Text="Price" ></asp:Label><br/>
            <asp:TextBox ID="TextBox4" runat="server" class="inputs" placeholder="price"></asp:TextBox><br />
         </div>

         <div class="passcards">
            <asp:Label ID="Label5" runat="server" Text="Quantity" ></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" class="inputs" placeholder="quantity"></asp:TextBox><br />
         </div>
         <div class="passcards">
             <asp:Label ID="Label3" runat="server" Text="Image" ></asp:Label><br/>
             <asp:FileUpload ID="FileUpload1" runat="server" />            
        </div>
        <div class="buttons">
            <asp:Button ID="Button1" runat="server" class="btn" Text="Cancel" />
        
            <asp:Button ID="Button4" runat="server"  class="btn" Text="Confirm" />
        </div>
    </div>
</div>
</asp:Content>
