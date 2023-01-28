using my_book_training_api.Data.Models;
using System;

namespace my_book_training_api.Data.ViewModels
{
    public class CustomActionResultVM
    {
        public Exception Exception { get; set; }
        public Publisher Publisher { get; set; }
    }
}
