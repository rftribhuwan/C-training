CREATE TABLE [dbo].[BusBooking] (
    [SrNo]        INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (20) NULL,
    [Phone]       VARCHAR (12) NULL,
    [Email]       VARCHAR (20) NULL,
    [Source]      VARCHAR (10) NULL,
    [Destination] VARCHAR (10) NULL,
    [TravelDate]  VARCHAR (30) NULL,
    [Timing]      VARCHAR (10) NULL,
    [SeatNos]     VARCHAR (70) NULL,
    [Price]       VARCHAR (10) NULL
);

