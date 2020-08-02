
SET IDENTITY_INSERT [dbo].[LocalGuardians] ON

INSERT into [dbo].[LocalGuardians]
    ( [LocalGuardianID],[LGName],[LGAddress],[LGContactNumer]
      ,[LGOccupation],[RelationWithParent],[AdharNumber],[CreatedBy]
      ,[CreatedDate])
VALUES
    (   
        1, 'LG Name', 'LG Address here', 1234567891, 'Job Name', 
        'Friends of Parent', 003300330033, 01, GETDATE()
    )   
SET IDENTITY_INSERT [dbo].[LocalGuardians] OFF

SET IDENTITY_INSERT [dbo].[ParentDetails] ON
INSERT INTO [dbo].[ParentDetails] 
( [ParentID],[FathersName], [MothersName],[ParentAddress],[ParentContactNumer]
    ,[ParentOccupation],[AdharNumber],[CreatedBy],[CreatedDate]
    ,[LocalGuardianID])
VALUES 
(
    1, 'Father', 'Mother', 'some address', 1234567890, 'Some Job', 
    333344449999, 1, GETDATE(),1
)

SET IDENTITY_INSERT [dbo].[ParentDetails] OFF


SET IDENTITY_INSERT [dbo].StudentDetails ON

INSERT INTO  [dbo].[StudentDetails]
([StudentID], [StudentRollNumber],[StudentClass],[StudentName],
 [DateOfBirth] ,[StudentAge],[studentSex],[CurrentAddress], 
 [PermanentAddress], [ContactNumber], [Nationality],
 [CreatedBy], [CreatedDate],[LocalGuardianID],
 [ParentDtailsParentID])
values (
    1, 01, '7th', 'First', '01/12/1982', 14, 'Male', 'Address is here', 
    'Same address', 99009900, 'Indian', 01, GETDATE(),1,1
);

SET IDENTITY_INSERT [dbo].StudentDetails OFF
