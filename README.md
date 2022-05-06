# StudyMe
StudyMe is a course management system (CMS) desinged to make it easy for course centers to organize their course and students.

In order to use the app the only thing you'll need is to change the location of the database on your PC as this location changes from a device to another.
You can do this by going to Server Explorer -> Add Database --> Select the database file (GameStoreDataBase.mdf) --> right-click on the database in Server Explorer
and select Properties --> Locate the Connection String then copy it --> go to the ProductForm.cs code and replace the SQLConnection con directory with the copied 
Connection String --> Voila you're good to go! 
