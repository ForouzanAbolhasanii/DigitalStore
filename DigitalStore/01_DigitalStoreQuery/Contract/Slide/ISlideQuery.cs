using System;
using System.Collections.Generic;


namespace _01_DigitalStoreQuery.Contract.Slide
{
   public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}
