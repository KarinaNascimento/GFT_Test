CREATE TYPE [dbo].[tbTrade] AS TABLE(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [decimal](18, 0) NULL,
	[ClientSector] [nvarchar](50) NULL,
	PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)

