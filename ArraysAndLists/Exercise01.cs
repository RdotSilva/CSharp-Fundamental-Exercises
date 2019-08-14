using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Exercise01
    // When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
    // If no one likes your post, it doesn't display anything.
    // If only one person likes your post, it displays: [Friend's Name] likes your post.
    // If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
    // If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
    // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
    // Depending on the number of names provided, display a message based on the above pattern.
    {
        public void Exercise()
        {
            var nameList = new List<string>();
            

            while (true)
            {
                Console.WriteLine("Enter a name or press ENTER to quit: ");

                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    break;
                nameList.Add(input);

            }

            var nameListLength = nameList.Count;

            if (nameListLength > 2)
                Console.WriteLine("{0}, {1}, and {2} other people liked your post", nameList[0], nameList[1], nameListLength - 2);
            else if (nameListLength == 2)
                Console.WriteLine("{0} and {1} like your post", nameList[0], nameList[1]);
            else if (nameListLength == 1)
                Console.WriteLine("{0} likes your post", nameList[0]);
        }
    }
}
