using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pageComments_Pages_PageId",
                table: "pageComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_pageGroups_pagegroupGroupId",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pages",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pageGroups",
                table: "pageGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pageComments",
                table: "pageComments");

            migrationBuilder.RenameTable(
                name: "Pages",
                newName: "Page");

            migrationBuilder.RenameTable(
                name: "pageGroups",
                newName: "pageGroup");

            migrationBuilder.RenameTable(
                name: "pageComments",
                newName: "pageComment");

            migrationBuilder.RenameIndex(
                name: "IX_Pages_pagegroupGroupId",
                table: "Page",
                newName: "IX_Page_pagegroupGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_pageComments_PageId",
                table: "pageComment",
                newName: "IX_pageComment_PageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Page",
                table: "Page",
                column: "PageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pageGroup",
                table: "pageGroup",
                column: "GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pageComment",
                table: "pageComment",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Page_pageGroup_pagegroupGroupId",
                table: "Page",
                column: "pagegroupGroupId",
                principalTable: "pageGroup",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_pageComment_Page_PageId",
                table: "pageComment",
                column: "PageId",
                principalTable: "Page",
                principalColumn: "PageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Page_pageGroup_pagegroupGroupId",
                table: "Page");

            migrationBuilder.DropForeignKey(
                name: "FK_pageComment_Page_PageId",
                table: "pageComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pageGroup",
                table: "pageGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pageComment",
                table: "pageComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Page",
                table: "Page");

            migrationBuilder.RenameTable(
                name: "pageGroup",
                newName: "pageGroups");

            migrationBuilder.RenameTable(
                name: "pageComment",
                newName: "pageComments");

            migrationBuilder.RenameTable(
                name: "Page",
                newName: "Pages");

            migrationBuilder.RenameIndex(
                name: "IX_pageComment_PageId",
                table: "pageComments",
                newName: "IX_pageComments_PageId");

            migrationBuilder.RenameIndex(
                name: "IX_Page_pagegroupGroupId",
                table: "Pages",
                newName: "IX_Pages_pagegroupGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pageGroups",
                table: "pageGroups",
                column: "GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pageComments",
                table: "pageComments",
                column: "CommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pages",
                table: "Pages",
                column: "PageId");

            migrationBuilder.AddForeignKey(
                name: "FK_pageComments_Pages_PageId",
                table: "pageComments",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "PageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_pageGroups_pagegroupGroupId",
                table: "Pages",
                column: "pagegroupGroupId",
                principalTable: "pageGroups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
