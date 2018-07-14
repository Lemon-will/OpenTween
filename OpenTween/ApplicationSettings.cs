// OpenTween - Client of Twitter
// Copyright (c) 2012      kim_upsilon (@kim_upsilon) <https://upsilo.net/~upsilon/>
// All rights reserved.
// 
// This file is part of OpenTween.
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General public License as published by the Free
// Software Foundation; either version 3 of the License, or (at your option)
// any later version.
// 
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General public License
// for more details.
// 
// You should have received a copy of the GNU General public License along
// with this program. If not, see <http://www.gnu.org/licenses/>, or write to
// the Free Software Foundation, Inc., 51 Franklin Street - Fifth Floor,
// Boston, MA 02110-1301, USA.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenTween
{
    /// <summary>
    /// アプリケーション固有の情報を格納します
    /// </summary>
    /// <remarks>
    /// OpenTween の派生版を作る方法は http://sourceforge.jp/projects/opentween/wiki/HowToFork を参照して下さい。
    /// </remarks>
    internal static class ApplicationSettings
    {
        //=====================================================================
        // アプリケーション情報

        /// <summary>
        /// アプリケーション名
        /// </summary>
        /// <remarks>
        /// 派生版のアプリケーションでは名前にマルチバイト文字を含む場合があります。
        /// ファイル名など英数字のみを含めたい用途ではこのプロパティではなく <see cref="AssemblyName"/> を使用します
        /// </remarks>
        public static string ApplicationName => Application.ProductName;

        /// <summary>
        /// アセンブリ名
        /// </summary>
        public static string AssemblyName => MyCommon.GetAssemblyName();

        //=====================================================================
        // フィードバック送信先
        // 異常終了時などにエラーログ等とともに表示されます。
        
        /// <summary>
        /// フィードバック送信先 (メール)
        /// </summary>
        public const string FeedbackEmailAddress = "lemonwill.poke@gmail.com";

        /// <summary>
        /// フィードバック送信先 (Twitter)
        /// </summary>
        public const string FeedbackTwitterName = "@Lemon_will";

        /// <summary>
        /// FeedbackTwitterName のユーザー宛にエラーレポートの DM を送信可能であるか
        /// </summary>
        /// <remarks>
        /// エラーレポートを DM で受け付ける場合は、フォロー外からの DM を受け付ける設定にする必要があります
        /// </remarks>
        public static readonly bool AllowSendErrorReportByDM = true;

        //=====================================================================
        // Web サイト

        /// <summary>
        /// 「ヘルプ」メニューの「(アプリ名) ウェブサイト」クリック時に外部ブラウザで表示する URL
        /// </summary>
        public const string WebsiteUrl = "https://github.com/Lemon-will/OpenTweenVxV";

        /// <summary>
        /// 「ヘルプ」メニューの「ショートカットキー一覧」クリック時に外部ブラウザで表示する URL
        /// </summary>
        /// <remarks>
        /// Tween の Wiki ページのコンテンツはプロプライエタリなため転載不可
        /// </remarks>
        public const string ShortcutKeyUrl = "http://sourceforge.jp/projects/tween/wiki/%E3%82%B7%E3%83%A7%E3%83%BC%E3%83%88%E3%82%AB%E3%83%83%E3%83%88%E3%82%AD%E3%83%BC";

        //=====================================================================
        // アップデートチェック関連

        /// <summary>
        /// 最新バージョンの情報を取得するためのURL
        /// </summary>
        /// <remarks>
        /// version.txt のフォーマットについては http://sourceforge.jp/projects/opentween/wiki/VersionTxt を参照。
        /// 派生プロジェクトなどでこの機能を無効にする場合は null をセットして下さい。
        /// </remarks>
        public static readonly string VersionInfoUrl = "https://www.opentween.org/status/version.txt";

        //=====================================================================
        // Twitter
        // https://apps.twitter.com/ から取得できます。

        /// <summary>
        /// Twitter コンシューマーキー
        /// </summary>
        public const string TwitterConsumerKey = "JVTaFFS6g5yhdJ6PyioQ2aqLO";
        public const string TwitterConsumerSecret = "iyMJHhveCXDGlgiuUB2A5WcMdiG8NlTGL4CSBIgk8qWqfjHkjj";

        //=====================================================================
        // Foursquare
        // https://developer.foursquare.com/ から取得できます。

        /// <summary>
        /// Foursquare Client Id
        /// </summary>
        public const string FoursquareClientId = "14VP4NHTQGX1R0TBKSFY1CBSMMZQ0FZY5QZ3MN554JLYXGNZ";

        /// <summary>
        /// Foursquare Client Secret
        /// </summary>
        public const string FoursquareClientSecret = "HLEKQ55GPT2JRVOMV14SSIPXWJ04R0QTOYLXCHWSZDU21GUK";

        //=====================================================================
        // bit.ly
        // https://bitly.com/a/oauth_apps から取得できます。

        /// <summary>
        /// bit.ly Client ID
        /// </summary>
        public const string BitlyClientId = "66c62ed278f40ad0372949dc910c20bad78074d4";

        /// <summary>
        /// bit.ly Client Secret
        /// </summary>
        public const string BitlyClientSecret = "a77055ca2451f26cd48d79ece9ae2c237bb9731b";

        //=====================================================================
        // TINAMI
        // http://www.tinami.com/api/ から取得できます。

        /// <summary>
        /// TINAMI APIキー
        /// </summary>
        public const string TINAMIApiKey = "5a8c09a2ac4ea";

        //=====================================================================
        // Microsoft Translator API (Cognitive Service)
        // https://www.microsoft.com/ja-jp/translator/getstarted.aspx から取得できます。

        /// <summary>
        /// Translator Text API Subscription Key
        /// 一時的にDeplicate
        /// </summary>
        public readonly static string TranslatorSubscriptionKey = "";

        //=====================================================================
        // Imgur
        // https://api.imgur.com/oauth2/addclient から取得できます

        /// <summary>
        /// Imgur Client ID
        /// </summary>
        public readonly static string ImgurClientID = "6f2eaecf24070c9";

        /// <summary>
        /// Imgur Client Secret
        /// </summary>
        public readonly static string ImgurClientSecret = "b3e298a71472f265ea07472be4d8e11ebd80b135";

        //=====================================================================
        // Mobypicture
        // http://www.mobypicture.com/apps/my から取得できます

        /// <summary>
        /// Mobypicture Developer Key
        /// </summary>
        public readonly static string MobypictureKey = "L0wQytgNfgaSDot4";

        //=====================================================================
        // Tumblr
        // https://www.tumblr.com/oauth/apps から取得できます

        /// <summary>
        /// Tumblr OAuth Consumer Key
        /// </summary>
        public readonly static string TumblrConsumerKey = "6CmuO1aDouGGKP9QUTVAQVLyL0lfcjxxDUUQE4CJ9aKtAVkH5e";
    }
}
