<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="categories.aspx.cs" Inherits="adminpage.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="dash">
        <!--category creation-->
    <div class="passbox1">
        <h2>Create Category</h2>
        <div class="passcards1"> 
            <asp:Image ID="Image1" runat="server" /><br />
            <asp:FileUpload ID="FileUpload2" runat="server" />
            <asp:Label ID="Label6" runat="server" Text="Category Name"></asp:Label>
            <asp:TextBox ID="tblcatname" runat="server" class="inputs" ></asp:TextBox>
            <br />
            <asp:Button ID="btnadd" runat="server" Text="Add" OnClick="btnadd_Click" />
            <br />
            <asp:Label ID="lbldis" runat="server" Text="Label"></asp:Label>
    </div>
        <!--product creation-->
    <div class="passbox">
        <h2>Create Product</h2>        
        <div class="passcards">            
            <asp:Label ID="Label1" runat="server" Text="Category Name" ></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" class="inputs" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name" AutoPostBack="True" >
                <asp:ListItem>Vegetables</asp:ListItem>
                <asp:ListItem>Fruits</asp:ListItem>
            </asp:DropDownList> 
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kapfarmConnectionString %>" SelectCommand="SELECT [name] FROM [Categories]"></asp:SqlDataSource>
        </div>

         <div class="passcards">
            <asp:Label ID="Label2" runat="server" Text="Product name" ></asp:Label>
            <asp:TextBox ID="txtprodname" runat="server" class="inputs" placeholder="product name"></asp:TextBox><br />
         </div>

        <div class="passcards">
            <asp:Label ID="Label4" runat="server" Text="Price" ></asp:Label><br/>
            <asp:TextBox ID="txtprice" runat="server" class="inputs" placeholder="price"></asp:TextBox><br />
         </div>

         <div class="passcards">
            <asp:Label ID="Label5" runat="server" Text="Quantity" ></asp:Label>
            <asp:TextBox ID="txtquantity" runat="server" class="inputs" placeholder="quantity"></asp:TextBox><br />
         </div>
         <div class="passcards">
             <asp:Label ID="Label3" runat="server" Text="Image" ></asp:Label><br/>
             <asp:FileUpload ID="FileUpload1" runat="server" />            
        </div>
        <div class="buttons">
            <asp:Button ID="Button1" runat="server" class="btn" Text="Cancel" OnClick="Button1_Click" />
        
            <asp:Button ID="Button4" runat="server"  class="btn" Text="Confirm" OnClick="Button4_Click" />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbldis2" runat="server" Text="Label"></asp:Label>
    </div>
</div>
    </div>
</asp:Content>
