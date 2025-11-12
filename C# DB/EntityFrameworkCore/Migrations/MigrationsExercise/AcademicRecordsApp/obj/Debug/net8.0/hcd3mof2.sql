BEGIN TRANSACTION;
CREATE TABLE [Courses] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY ([Id])
);

CREATE TABLE [StudentsCourses] (
    [StudentId] int NOT NULL,
    [CourseId] int NOT NULL,
    CONSTRAINT [PK_StudentsCourses] PRIMARY KEY ([StudentId], [CourseId]),
    CONSTRAINT [FK_StudentsCourses_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([Id]),
    CONSTRAINT [FK_StudentsCourses_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([Id])
);

CREATE INDEX [IX_StudentsCourses_CourseId] ON [StudentsCourses] ([CourseId]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251110144428_AddCoursesEntity', N'9.0.10');

COMMIT;
GO

