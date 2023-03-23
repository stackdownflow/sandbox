/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO SB.ROLE VALUES('Developer');
INSERT INTO SB.ROLE VALUES('Quality Assurance');
INSERT INTO SB.ROLE VALUES('BSA');


INSERT INTO SB.EMPLOYEE VALUES('John','Doe','john.doe@deloitte.com',1,25000);
INSERT INTO SB.EMPLOYEE VALUES('Jane','Doe','jane.doe@deloitte.com',2,15000);
INSERT INTO SB.EMPLOYEE VALUES('Michael','Doe','michael.doe@deloitte.com',1,25000);
INSERT INTO SB.EMPLOYEE VALUES('Rachel','Doe','rachel.doe@deloitte.com',3,45000);
INSERT INTO SB.EMPLOYEE VALUES('Mike','Doe','mike.doe@deloitte.com',1,25000);
INSERT INTO SB.EMPLOYEE VALUES('Ronald','Doe','ronald.doe@deloitte.com',2,15000);
INSERT INTO SB.EMPLOYEE VALUES('Jacob','Doe','jacob.doe@deloitte.com',3,45000);
INSERT INTO SB.EMPLOYEE VALUES('Damon','Doe','damon.doe@deloitte.com',2,15000);
INSERT INTO SB.EMPLOYEE VALUES('Stefan','Doe','stefan.doe@deloitte.com',3,45000);
INSERT INTO SB.EMPLOYEE VALUES('Vanessa','Doe','vanessa.doe@deloitte.com',2,15000);
