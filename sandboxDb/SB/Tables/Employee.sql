CREATE TABLE [SB].[Employee] (
    [EmpId]      INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (20) NOT NULL,
    [LastName]   VARCHAR (20) NOT NULL,
    [Email]      VARCHAR (25) NOT NULL,
    [RoleRoleId] INT          NOT NULL,
    [Salary]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([EmpId] ASC),
    FOREIGN KEY ([RoleRoleId]) REFERENCES [SB].[Role] ([RoleId])
);

