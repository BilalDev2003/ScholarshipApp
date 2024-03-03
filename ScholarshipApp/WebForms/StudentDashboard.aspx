<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MasterPage.master" AutoEventWireup="true" CodeFile="StudentDashboard.aspx.cs" Inherits="WebForms_StudentDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- for main part -->
    <form runat="server">
        <div class="main">
            <div class="searchbar2">
                <input type="text"
                    name=""
                    id=""
                    placeholder="Search">
                <div class="searchbtn">
                    <img src="https://media.geeksforgeeks.org/wp-content/uploads/20221210180758/Untitled-design-(28).png"
                        class="icn srchicn"
                        alt="search-button">
                </div>
            </div>
            <asp:Button runat="server" ID="btnBox1" Style="display: none" OnClick="btnBox1_Click" />
            <!-- for main part -->
            <asp:Button runat="server" ID="btnBox2" Style="display: none" OnClick="btnBox2_Click" />
            <!-- for main part -->
            <asp:Button runat="server" ID="btnBox3" Style="display: none" OnClick="btnBox3_Click" />
            <!-- for main part -->
            <asp:Button runat="server" ID="btnBox4" Style="display: none" OnClick="btnBox4_Click" />
            <!-- for main part -->

            <div class="box-container">
                <div class="box box1" onclick="document.getElementById('<%= btnBox1.ClientID %>').click()">
                    <!-- pressing a button with div click -->

                    <div class="text">
                        <h2 class="topic-heading">Apply</h2>
                        <h2 class="topic">Fresh</h2>
                    </div>
                </div>

                <div class="box box2" onclick="document.getElementById('<%= btnBox2.ClientID %>').click()">
                    <!-- pressing a button with div click -->

                    <div class="text">
                        <h2 class="topic-heading">Apply</h2>
                        <h2 class="topic">Correction</h2>
                    </div>
                </div>

                <div class="box box3" onclick="document.getElementById('<%= btnBox3.ClientID %>').click()">
                    <!-- pressing a button with div click -->

                    <div class="text">
                        <h2 class="topic-heading">Track</h2>
                        <h2 class="topic">Existing</h2>
                    </div>
                </div>

                <div class="box box4" onclick="document.getElementById('<%= btnBox4.ClientID %>').click()">
                    <!-- pressing a button with div click -->

                    <div class="text">
                        <h2 class="topic-heading">Profile</h2>
                        <h2 class="topic">Details</h2>
                    </div>
                </div>
            </div>

            <div class="report-container">
                <div class="report-header">
                    <h1 class="recent-Articles">Recent Articles</h1>
                    <button class="view">View All</button>
                </div>

                <div class="report-body">
                    <div class="report-topic-heading">
                        <h3 class="t-op">Article</h3>
                        <h3 class="t-op">Views</h3>
                        <h3 class="t-op">Comments</h3>
                        <h3 class="t-op">Status</h3>
                    </div>

                    <div class="items">
                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 73</h3>
                            <h3 class="t-op-nextlvl">2.9k</h3>
                            <h3 class="t-op-nextlvl">210</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 72</h3>
                            <h3 class="t-op-nextlvl">1.5k</h3>
                            <h3 class="t-op-nextlvl">360</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 71</h3>
                            <h3 class="t-op-nextlvl">1.1k</h3>
                            <h3 class="t-op-nextlvl">150</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 70</h3>
                            <h3 class="t-op-nextlvl">1.2k</h3>
                            <h3 class="t-op-nextlvl">420</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 69</h3>
                            <h3 class="t-op-nextlvl">2.6k</h3>
                            <h3 class="t-op-nextlvl">190</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 68</h3>
                            <h3 class="t-op-nextlvl">1.9k</h3>
                            <h3 class="t-op-nextlvl">390</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 67</h3>
                            <h3 class="t-op-nextlvl">1.2k</h3>
                            <h3 class="t-op-nextlvl">580</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 66</h3>
                            <h3 class="t-op-nextlvl">3.6k</h3>
                            <h3 class="t-op-nextlvl">160</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                        <div class="item1">
                            <h3 class="t-op-nextlvl">Article 65</h3>
                            <h3 class="t-op-nextlvl">1.3k</h3>
                            <h3 class="t-op-nextlvl">220</h3>
                            <h3 class="t-op-nextlvl label-tag">Published</h3>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </form>
    <!-- end main part -->
</asp:Content>

