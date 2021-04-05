CREATE PROCEDURE SP_GFT_CREATE_TABLE_SECTOR
@STANDARDVALUES AS BIT = 0
AS
BEGIN 

BEGIN TRY

	CREATE TABLE [DBO].[SECTOR](
		[ID] [INT] IDENTITY(1,1) NOT NULL,
		[SECTOR] [NVARCHAR](50) NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)WITH (PAD_INDEX = OFF, 
			STATISTICS_NORECOMPUTE = OFF, 
			IGNORE_DUP_KEY = OFF, 
			ALLOW_ROW_LOCKS = ON, 
			ALLOW_PAGE_LOCKS = ON, 
			OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]


	IF (@STANDARDVALUES > 0)
	BEGIN 
		INSERT INTO [DBO].[SECTOR] VALUES('PUBLIC');
		INSERT INTO [DBO].[SECTOR] VALUES('PRIVATE');
	END 

END TRY
BEGIN CATCH

	DECLARE @ERRORMESSAGE NVARCHAR(4000);  
    DECLARE @ERRORSEVERITY INT;  
    DECLARE @ERRORSTATE INT;  
  
    SELECT   
        @ERRORMESSAGE = ERROR_MESSAGE(),  
        @ERRORSEVERITY = ERROR_SEVERITY(),  
        @ERRORSTATE = ERROR_STATE();  
  
    RAISERROR (@ERRORMESSAGE, 
               @ERRORSEVERITY,
               @ERRORSTATE
               );  
END CATCH

END