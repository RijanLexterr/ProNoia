echo off
sqlcmd -E -S LEX -i DatabseCreation.sql
sqlcmd -E -S LEX -i CreateTables.sql
sqlcmd -E -S LEX -i SP_User.sql
sqlcmd -E -S LEX -i SP_ProductType.sql
sqlcmd -E -S LEX -i SEED_AddAdmin.sql
set /p delExit=Press the ENTER key to exit...: