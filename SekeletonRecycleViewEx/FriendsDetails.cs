using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SekeletonRecycleViewEx
{
    class Friends
    {
        public Friends(int id, string name, string description)
        { 
            PhotoId = id;
            Fname = name;
            Fdescription = description;

        }

        public int PhotoId { get; }
        public string Fname { get; }
        public string Fdescription { get; }
    }
    class FriendsDetails
    {

        static Friends[] frnd = {

            new Friends(Resource.Drawable.ross,"Ross Geller","The Dinosour Guy"),
            new Friends(Resource.Drawable.rachel,"Rachel Green","Raquel"),
            new Friends(Resource.Drawable.chandler,"Chandler Bing","Miss Chanandler Bong"),
            new Friends(Resource.Drawable.monica,"Monica Geller","The Chef"),
            new Friends(Resource.Drawable.joe,"Joey Tribbiani","Kan Adams"),
            new Friends(Resource.Drawable.pheobe,"Phoebe Buffay","Ragina Phelange"),
            new Friends(Resource.Drawable.ross,"Ross Geller","The Dinosour Guy"),
            new Friends(Resource.Drawable.rachel,"Rachel Green","Raquel"),
            new Friends(Resource.Drawable.chandler,"Chandler Bing","Miss Chanandler Bong"),
            new Friends(Resource.Drawable.monica,"Monica Geller","The Chef"),
            new Friends(Resource.Drawable.joe,"Joey Tribbiani","Kan Adams"),
            new Friends(Resource.Drawable.pheobe,"Phoebe Buffay","Ragina Phelange"),
            new Friends(Resource.Drawable.ross,"Ross Geller","The Dinosour Guy"),
            new Friends(Resource.Drawable.rachel,"Rachel Green","Raquel"),
            new Friends(Resource.Drawable.chandler,"Chandler Bing","Miss Chanandler Bong"),
            new Friends(Resource.Drawable.monica,"Monica Geller","The Chef"),
            new Friends(Resource.Drawable.joe,"Joey Tribbiani","Kan Adams"),
            new Friends(Resource.Drawable.pheobe,"Phoebe Buffay","Ragina Phelange"),
            new Friends(Resource.Drawable.ross,"Ross Geller","The Dinosour Guy"),
            new Friends(Resource.Drawable.rachel,"Rachel Green","Raquel"),
            new Friends(Resource.Drawable.chandler,"Chandler Bing","Miss Chanandler Bong"),
            new Friends(Resource.Drawable.monica,"Monica Geller","The Chef"),
            new Friends(Resource.Drawable.joe,"Joey Tribbiani","Kan Adams"),
            new Friends(Resource.Drawable.pheobe,"Phoebe Buffay","Ragina Phelange"),

            };

        private Friends[] mfrnd;

        Random random;

        public FriendsDetails()
        {
            mfrnd = frnd;
            random = new Random();
        }

        public int NumbFriends
        {

            get { return mfrnd.Length; }
        }

        public Friends this[int i]
        {
            get { return mfrnd[i]; }
        }

        public int RandomSwap()
        {
            Friends tempfrnd = mfrnd[0];

            int mrandom = random.Next(1, mfrnd.Length);

            mfrnd[0] = mfrnd[mrandom];
            mfrnd[mrandom] = tempfrnd;

            return mrandom;
        }

        public void Suffle()
        {
            for (int i = 0; i < mfrnd.Length; i++)
            {
                Friends tempfrnd = mfrnd[i];
             

                int mrandom = random.Next(1, mfrnd.Length);

                mfrnd[i] = mfrnd[mrandom];
                mfrnd[mrandom] = tempfrnd;
            }

        }
    }
}