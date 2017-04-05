﻿using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {

        // --------------------------  ARRAYS  --------------------------------------------

        /// <summary>
        /// Determines whether an array contains a specified element by using the 
        /// provided IEqualityComparer or the default comparer if none is provided.
        /// </summary>        
        /// <param name="source">An array in which to locate a value.</param>
        /// <param name="value">The value to locate.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        public static bool ContainsF<TSource>(this TSource[] source, TSource value, IEqualityComparer<TSource> comparer = null)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (comparer == null)
            {
                comparer = EqualityComparer<TSource>.Default;
            }


            for (int i = 0; i < source.Length; i++)
            {
                if (comparer.Equals(source[i], value))
                {
                    return true;
                }
            }

            return false;
        }

        // --------------------------  Lists --------------------------------------------

        /// <summary>
        /// Determines whether a list contains a specified element by using the 
        /// provided IEqualityComparer or the default comparer if none is provided.
        /// </summary>        
        /// <param name="source">A list in which to locate a value.</param>
        /// <param name="value">The value to locate.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        public static bool ContainsF<TSource>(this List<TSource> source, TSource value, IEqualityComparer<TSource> comparer = null)
        {
            if (source == null)
            {
                throw Error.ArgumentNull(nameof(source));
            }

            if (comparer == null)
            {
                comparer = EqualityComparer<TSource>.Default;
            }


            for (int i = 0; i < source.Count; i++)
            {
                if (comparer.Equals(source[i], value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
