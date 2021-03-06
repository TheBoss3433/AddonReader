﻿namespace TenBot.AddonReader.Boxes
{
    public class BoxBuilder
    {
        private readonly AddonConfigProvider _addonConfig;
        private readonly BitmapProvider _bitmapProvider;

        public BoxBuilder(AddonConfigProvider config, BitmapProvider bitmapProvider)
        {
            _addonConfig = config;
            _bitmapProvider = bitmapProvider;
           
        }

        public int ErrorInt => _addonConfig.ErrorInt;

        public Box BuildFromParse(string dataFrame)
        {
            var paramStrings = dataFrame.Split(";");
            var index = int.Parse(paramStrings[0]);
           // var framesId = paramStrings[1];
            var name = paramStrings[2];
            var p = _addonConfig.GetPointFromIndex(index);

            return new Box(index, p, name, _bitmapProvider);
        }
    }
}