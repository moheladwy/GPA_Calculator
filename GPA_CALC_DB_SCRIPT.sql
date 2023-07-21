SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id]          [int]           IDENTITY(1,1) NOT NULL,
	[CourseName]  [nvarchar](250)               NOT NULL,
	[CreditHours] [int]                         NOT NULL,
	[Grade]       [varchar](2)                  NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Courses] ADD PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
---------------------------------------------------------------------------
USING GPA_Calculator
GO
---------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[Courses_Insert]
    @CourseName NVARCHAR(250),
    @CreditHours INT,
    @Grade VARCHAR(2),
    @id INT = 0 OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO [dbo].[Courses] (CourseName, CreditHours, Grade)
    VALUES (@CourseName, @CreditHours, @Grade);

    SELECT @id = SCOPE_IDENTITY();
END
GO
---------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[spCourses_GetAll]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM [dbo].[Courses] ORDER BY id;
END
GO
---------------------------------------------------------------------------