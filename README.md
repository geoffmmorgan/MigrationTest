# MigrationTest
UWP Demo showing issue generating migrations with EF core and Win2d

EF core migrations cannot be generated in a project that uses Win2D's CanvasBitmap.LoadAsync
Simply run the ef command "Add-Migration Initial" in the Package Manager Console to get the error: System.Reflection.ReflectionTypeLoadException: Unable to load one or more of the requested types. Retrieve the LoaderExceptions property for more information.

This is due to the following line in MainPage.xaml
await CanvasBitmap.LoadAsync(this.BlurredImage, new Uri("http://logok.org/wp-content/uploads/2014/09/Bing-logo-880x633.png"));
