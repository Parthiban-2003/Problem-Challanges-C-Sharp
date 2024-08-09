//using System;

//public class PhotoBookTest
//{
//    public static void Main()
//    {
//        PhotoBook myAlbum1 = new PhotoBook();
//        Console.WriteLine(myAlbum1.GetNumberPages());

//        PhotoBook myAlbum2 = new PhotoBook(24);
//        Console.WriteLine(myAlbum2.GetNumberPages());

//        SuperPhotoBook myBigPhotoAlbum1 = new SuperPhotoBook();
//        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
//    }
//}

//public class PhotoBook
//{
//    public int nNumPages;

//    public PhotoBook()
//    {
//        nNumPages = 16;
//    }

//    public PhotoBook(int nNumPages)
//    {
//        this.nNumPages = nNumPages;
//    }

//    public int GetNumberPages()
//    {
//        return nNumPages;
//    }
//}

//public class SuperPhotoBook : PhotoBook
//{
//    public SuperPhotoBook()
//    {
//        nNumPages = 64;
//    }
//}