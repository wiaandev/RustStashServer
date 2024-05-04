using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RustStashServer.Core.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTableAttribute231234567io3456 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategory_Categories_CategoryId1",
                table: "MaterialCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategory_Materials_MaterialId1",
                table: "MaterialCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Materials_MaterialId1",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId1",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_UserStashMaterials_Materials_MaterialId1",
                table: "UserStashMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_UserStashMaterials_UserStashes_UserStashId1",
                table: "UserStashMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserStashMaterials",
                table: "UserStashMaterials");

            migrationBuilder.DropIndex(
                name: "IX_UserStashMaterials_MaterialId1",
                table: "UserStashMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_MaterialId1",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialCategory",
                table: "MaterialCategory");

            migrationBuilder.DropIndex(
                name: "IX_MaterialCategory_CategoryId1",
                table: "MaterialCategory");

            migrationBuilder.RenameColumn(
                name: "UserStashId1",
                table: "UserStashMaterials",
                newName: "MaterialIds");

            migrationBuilder.RenameColumn(
                name: "MaterialId1",
                table: "UserStashMaterials",
                newName: "UserStashIds");

            migrationBuilder.RenameIndex(
                name: "IX_UserStashMaterials_UserStashId1",
                table: "UserStashMaterials",
                newName: "IX_UserStashMaterials_MaterialIds");

            migrationBuilder.RenameColumn(
                name: "RecipeId1",
                table: "RecipeIngredients",
                newName: "MaterialIds");

            migrationBuilder.RenameColumn(
                name: "MaterialId1",
                table: "RecipeIngredients",
                newName: "RecipeIds");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_RecipeId1",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_MaterialIds");

            migrationBuilder.RenameColumn(
                name: "MaterialId1",
                table: "MaterialCategory",
                newName: "CategoryIds");

            migrationBuilder.RenameColumn(
                name: "CategoryId1",
                table: "MaterialCategory",
                newName: "MaterialIds");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialCategory_MaterialId1",
                table: "MaterialCategory",
                newName: "IX_MaterialCategory_CategoryIds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserStashMaterials",
                table: "UserStashMaterials",
                columns: new[] { "UserStashIds", "MaterialIds" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients",
                columns: new[] { "RecipeIds", "MaterialIds" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialCategory",
                table: "MaterialCategory",
                columns: new[] { "MaterialIds", "CategoryIds" });

            migrationBuilder.CreateIndex(
                name: "IX_UserStashMaterials_UserStashId",
                table: "UserStashMaterials",
                column: "UserStashId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCategory_MaterialId",
                table: "MaterialCategory",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategory_Categories_CategoryIds",
                table: "MaterialCategory",
                column: "CategoryIds",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategory_Materials_MaterialIds",
                table: "MaterialCategory",
                column: "MaterialIds",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Materials_MaterialIds",
                table: "RecipeIngredients",
                column: "MaterialIds",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeIds",
                table: "RecipeIngredients",
                column: "RecipeIds",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserStashMaterials_Materials_MaterialIds",
                table: "UserStashMaterials",
                column: "MaterialIds",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserStashMaterials_UserStashes_UserStashIds",
                table: "UserStashMaterials",
                column: "UserStashIds",
                principalTable: "UserStashes",
                principalColumn: "UserStashId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategory_Categories_CategoryIds",
                table: "MaterialCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialCategory_Materials_MaterialIds",
                table: "MaterialCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Materials_MaterialIds",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeIds",
                table: "RecipeIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_UserStashMaterials_Materials_MaterialIds",
                table: "UserStashMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_UserStashMaterials_UserStashes_UserStashIds",
                table: "UserStashMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserStashMaterials",
                table: "UserStashMaterials");

            migrationBuilder.DropIndex(
                name: "IX_UserStashMaterials_UserStashId",
                table: "UserStashMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients");

            migrationBuilder.DropIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaterialCategory",
                table: "MaterialCategory");

            migrationBuilder.DropIndex(
                name: "IX_MaterialCategory_MaterialId",
                table: "MaterialCategory");

            migrationBuilder.RenameColumn(
                name: "MaterialIds",
                table: "UserStashMaterials",
                newName: "UserStashId1");

            migrationBuilder.RenameColumn(
                name: "UserStashIds",
                table: "UserStashMaterials",
                newName: "MaterialId1");

            migrationBuilder.RenameIndex(
                name: "IX_UserStashMaterials_MaterialIds",
                table: "UserStashMaterials",
                newName: "IX_UserStashMaterials_UserStashId1");

            migrationBuilder.RenameColumn(
                name: "MaterialIds",
                table: "RecipeIngredients",
                newName: "RecipeId1");

            migrationBuilder.RenameColumn(
                name: "RecipeIds",
                table: "RecipeIngredients",
                newName: "MaterialId1");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeIngredients_MaterialIds",
                table: "RecipeIngredients",
                newName: "IX_RecipeIngredients_RecipeId1");

            migrationBuilder.RenameColumn(
                name: "CategoryIds",
                table: "MaterialCategory",
                newName: "MaterialId1");

            migrationBuilder.RenameColumn(
                name: "MaterialIds",
                table: "MaterialCategory",
                newName: "CategoryId1");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialCategory_CategoryIds",
                table: "MaterialCategory",
                newName: "IX_MaterialCategory_MaterialId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserStashMaterials",
                table: "UserStashMaterials",
                columns: new[] { "UserStashId", "MaterialId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeIngredients",
                table: "RecipeIngredients",
                columns: new[] { "RecipeId", "MaterialId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaterialCategory",
                table: "MaterialCategory",
                columns: new[] { "MaterialId", "CategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserStashMaterials_MaterialId1",
                table: "UserStashMaterials",
                column: "MaterialId1");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_MaterialId1",
                table: "RecipeIngredients",
                column: "MaterialId1");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialCategory_CategoryId1",
                table: "MaterialCategory",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategory_Categories_CategoryId1",
                table: "MaterialCategory",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialCategory_Materials_MaterialId1",
                table: "MaterialCategory",
                column: "MaterialId1",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Materials_MaterialId1",
                table: "RecipeIngredients",
                column: "MaterialId1",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeIngredients_Recipes_RecipeId1",
                table: "RecipeIngredients",
                column: "RecipeId1",
                principalTable: "Recipes",
                principalColumn: "RecipeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserStashMaterials_Materials_MaterialId1",
                table: "UserStashMaterials",
                column: "MaterialId1",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserStashMaterials_UserStashes_UserStashId1",
                table: "UserStashMaterials",
                column: "UserStashId1",
                principalTable: "UserStashes",
                principalColumn: "UserStashId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
