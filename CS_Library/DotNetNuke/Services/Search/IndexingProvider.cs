#region DotNetNuke License
// DotNetNukeŽ - http://www.dotnetnuke.com
// Copyright (c) 2002-2006
// by DotNetNuke Corporation
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion
using DotNetNuke.Framework;

namespace DotNetNuke.Services.Search
{
    public abstract class IndexingProvider
    {
        // singleton reference to the instantiated object
        private static IndexingProvider objProvider = null;

        // constructor
        static IndexingProvider()
        {
            CreateProvider();
        }

        // dynamically create provider
        private static void CreateProvider()
        {
            objProvider = (IndexingProvider)Reflection.CreateObject("searchIndex");
        }

        // return the provider
        public new static IndexingProvider Instance()
        {
            return objProvider;
        }

        public abstract SearchItemInfoCollection GetSearchIndexItems(int PortalID);
    }
}