using System;
using System.Collections.Generic;
using System.Text;

namespace quasar2._0
{    
    class RndUAgent
    {
        private List<string> UAgent = new List<string>(); // Список браузеров
        public RndUAgent()
        {
            /*ABrowse*/
            UAgent.Add("Mozilla/5.0 (compatible; U; ABrowse 0.6; Syllable) AppleWebKit/420+ (KHTML, like Gecko)");
            UAgent.Add("Mozilla/5.0 (compatible; ABrowse 0.4; Syllable)");
            /*Acoo Browser*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; Acoo Browser; GTB5; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; Maxthon; InfoPath.1; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0; Acoo Browser; GTB6; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; InfoPath.1; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0; Acoo Browser; GTB5; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; InfoPath.1; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; GTB6; Acoo Browser; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; Trident/4.0; Acoo Browser; GTB5; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; InfoPath.1; .NET CLR 3.5.30729; .NET CLR 3.0.30618)");
            /*America Online Browser*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; America Online Browser 1.1; Windows NT 5.1; (R1 1.5); .NET CLR 2.0.50727; InfoPath.1)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; America Online Browser 1.1; rev1.5; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; America Online Browser 1.1; rev1.5; Windows NT 5.1; .NET CLR 1.1.4322)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; America Online Browser 1.1; rev1.5; Windows NT 5.1; .NET CLR 1.0.3705; .NET CLR 1.1.4322; Media Center PC 4.0; InfoPath.1; .NET CLR 2.0.50727; Media Center PC 3.0; InfoPath.2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; America Online Browser 1.1; rev1.2; Windows NT 5.1; SV1; .NET CLR 1.1.4322)");
            /*AmigaVoyager*/
            UAgent.Add("AmigaVoyager/3.2 (AmigaOS/MC680x0)");
            UAgent.Add("AmigaVoyager/2.95 (compatible; MC680x0; AmigaOS; SV1)");
            UAgent.Add("AmigaVoyager/2.95 (compatible; MC680x0; AmigaOS)");
            /*AOL*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.27; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.27; Windows NT 5.1; Trident/4.0; .NET CLR 1.0.3705; .NET CLR 1.1.4322; Media Center PC 4.0; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; InfoPath.2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.17; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.12; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; AOL 9.6; AOLBuild 4340.12; Windows NT 5.1; Trident/4.0; GTB6.3)");
            /*Arora*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux; de-DE) AppleWebKit/527+ (KHTML, like Gecko, Safari/419.3) Arora/0.8.0");
            UAgent.Add("Mozilla/5.0 (Windows; U; ; en-NZ) AppleWebKit/527+ (KHTML, like Gecko, Safari/419.3) Arora/0.8.0");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux; ru-RU) AppleWebKit/527+ (KHTML, like Gecko, Safari/419.3) Arora/0.6 (Change: 802 025a17d)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux; fi-FI) AppleWebKit/527+ (KHTML, like Gecko, Safari/419.3) Arora/0.6 (Change: 754 46b659a)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux; en-US) AppleWebKit/527+ (KHTML, like Gecko, Safari/419.3) Arora/0.6");
            /*Avant Browser*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Avant Browser; .NET CLR 2.0.50727; MAXTHON 2.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; Avant Browser; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0; Avant Browser; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.0.04506; .NET CLR 3.5.21022; InfoPath.2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0; Avant Browser; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30618; InfoPath.1)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; GTB6.4; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; chromeframe; Avant Browser; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; InfoPath.1; .NET CLR 3.0.4506.");
            /*Beonex*/
            UAgent.Add("Mozilla/5.0 (Windows; U; WinNT; en; rv:1.0.2) Gecko/20030311 Beonex/0.8.2-stable");
            UAgent.Add("Mozilla/5.0 (Windows; U; WinNT; en; Preview) Gecko/20020603 Beonex/0.8-stable");
            /*BonEcho*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; nl; rv:1.8.1b2) Gecko/20060821 BonEcho/2.0b2 (Debian-1.99+2.0b2+dfsg-1)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1b2) Gecko/20060821 BonEcho/2.0b2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1b2) Gecko/20060826 BonEcho/2.0b2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8.1b2) Gecko/20060831 BonEcho/2.0b2");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-GB; rv:1.8.1b1) Gecko/20060601 BonEcho/2.0b1 (Ubuntu-edgy)");
            /*Camino*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en; rv:1.9.0.8pre) Gecko/2009022800 Camino/2.0b3pre");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en; rv:1.9.0.10pre) Gecko/2009041800 Camino/2.0b3pre (like Firefox/3.0.10pre)");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; en; rv:1.9.0.19) Gecko/2010111021 Camino/2.0.6 (MultiLang) (like Firefox/3.0.19)");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10.4; en; rv:1.9.0.19) Gecko/2010051911 Camino/2.0.3 (like Firefox/3.0.19)");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; nl; rv:1.9.0.19) Gecko/2010051911 Camino/2.0.3 (MultiLang) (like Firefox/3.0.19)");
            /*Charon*/
            UAgent.Add("Mozilla/4.08 (Charon; Inferno)");
            /*Cheshire*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/418.8 (KHTML, like Gecko, Safari) Cheshire/1.0.UNOFFICIAL");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en) AppleWebKit/418.9 (KHTML, like Gecko, Safari) Cheshire/1.0.UNOFFICIAL");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/419 (KHTML, like Gecko, Safari/419.3) Cheshire/1.0.ALPHA");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/418.9 (KHTML, like Safari) Cheshire/1.0.ALPHA");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/418.9 (KHTML, like Gecko, Safari) Safari/419.3 Cheshire/1.0.ALPHA");
            /*Chimera*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; pl-PL; rv:1.0.1) Gecko/20021111 Chimera/0.6");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en-US; rv:1.0.1) Gecko/20021111 Chimera/0.6");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en-US; rv:1.0.1) Gecko/20021104 Chimera/0.6");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.0.1) Gecko/20030111 Chimera/0.6");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.0.1) Gecko/20030109 Chimera/0.6");
            /*Chrome*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/540.0 (KHTML,like Gecko) Chrome/9.1.0.0 Safari/540.0");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/540.0 (KHTML, like Gecko) Ubuntu/10.10 Chrome/9.1.0.0 Safari/540.0");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/9.0.601.0 Safari/534.14");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Ubuntu/10.10 Chromium/9.0.600.0 Chrome/9.0.600.0 Safari/534.14");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.14 (KHTML, like Gecko) Chrome/9.0.600.0 Safari/534.14");
            /*ChromePlus*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; AppleWebKit/540.0 (KHTML, like Gecko) ChromePlus/4.0.222.3 Chrome/4.0.222.3 ) AppleWebKit/413 (KHTML, like Gecko) Safari/413");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/532.2 (KHTML, like Gecko) ChromePlus/4.0.222.3 Chrome/4.0.222.3 Safari/532.2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/525.28.3 (KHTML, like Gecko) Version/3.2.3 ChromePlus/4.0.222.3 Chrome/4.0.222.3 Safari/525.28.3");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.10 (KHTML, like Gecko) Chrome/8.0.552.216 Safari/534.10 ChromePlus/1.5.1.0alpha1");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Chrome/7.0.517.41 Safari/534.7 ChromePlus/1.5.0.0alpha1");
            /*CometBird*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.0.5) Gecko/2009011615 Firefox/3.0.5 CometBird/3.0.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.5) Gecko/2009011615 Firefox/3.0.5 CometBird/3.0.5");
            /*Comodo_Dragon*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/532.5 (KHTML, like Gecko) Comodo_Dragon/4.1.1.11 Chrome/4.1.249.1042 Safari/532.5");
            /*Crazy Browser*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; InfoPath.2; .NET CLR 2.0.50727; .NET CLR 1.1.4322; Crazy Browser 3.0.0 Beta2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Crazy Browser 3.0.0 Beta2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; InfoPath.2; OfficeLiveConnector.1.3; OfficeLivePatch.0.0; Crazy Browser 3.0.0 Beta2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; Crazy Browser 3.0.0 Beta2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; Crazy Browser 3.0.0 Beta2)");
            /*Cyberdog*/
            UAgent.Add("Cyberdog/2.0 (Macintosh; 68k)");
            /*Deepnet Explorer*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Deepnet Explorer 1.5.3; Smart 2x2; .NET CLR 2.0.50727; .NET CLR 1.1.4322; InfoPath.1)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Deepnet Explorer 1.5.3; Smart 2x2; .NET CLR 1.1.4322; InfoPath.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Deepnet Explorer 1.5.3; Smart 2x2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; Deepnet Explorer 1.5.3; Smart 2x2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; Deepnet Explorer 1.5.2; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; InfoPath.2)");
            /*DeskBrowse*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; pl-pl) AppleWebKit/312.8 (KHTML, like Gecko, Safari) DeskBrowse/1.0");
            /*Dillo*/
            UAgent.Add("Dillo/2.0");
            UAgent.Add("Dillo/0.8.6-i18n-misc");
            UAgent.Add("Dillo/0.8.6");
            UAgent.Add("Dillo/0.8.5-i18n-misc");
            UAgent.Add("Dillo/0.8.5");
            /*Dooble*/
            UAgent.Add("Dooble/0.07 (de_CH) WebKit");
            /*Element Browser*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533+ (KHTML, like Gecko) Element Browser 5.0");
            /*Elinks*/
            UAgent.Add("ELinks/0.9.3 (textmode; Linux 2.6.9-kanotix-8 i686; 127x41)");
            UAgent.Add("ELinks/0.9.3 (textmode; Linux 2.6.11-auditor-10 i686; 80x24)");
            UAgent.Add("ELinks/0.9.3 (textmode; Linux 2.6.11 i686; 79x24)");
            UAgent.Add("ELinks (0.4pre6; Linux 2.2.19ext3 alpha; 80x25)");
            UAgent.Add("ELinks (0.4pre5; Linux 2.6.10-ac7 i686; 80x33)");
            /*Enigma Browser*/
            UAgent.Add("Enigma Browser");
            /*Epiphany*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Epiphany/2.30.6 Safari/534.7");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; it-it) AppleWebKit/531.2+ (KHTML, like Gecko) Safari/531.2+ Epiphany/2.30.2");
            UAgent.Add("Mozilla/5.0 (X11; U; OpenBSD arm; en-us) AppleWebKit/531.2+ (KHTML, like Gecko) Safari/531.2+ Epiphany/2.30.0");
            UAgent.Add("Mozilla/5.0 (X11; U; FreeBSD amd64; en-us) AppleWebKit/531.2+ (KHTML, like Gecko) Safari/531.2+ Epiphany/2.30.0");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; nl-nl) AppleWebKit/531.2+ (KHTML, like Gecko) Safari/531.2+ Epiphany/2.29.91");
            /*Escape*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 5.23; Macintosh; PPC) Escape 5.1.8");
            /*Fennec*/
            UAgent.Add("Mozilla/5.0 (Windows NT 5.1; rv:2.0b6pre) Gecko/20100902 Firefox/4.0b6pre Fennec/2.0b1pre");
            UAgent.Add("Mozilla/5.0 (X11; Linux armv7l; rv:2.0b4pre) Gecko/20100818 Firefox/4.0b4pre Fennec/2.0a1pre");
            UAgent.Add("Mozilla/5.0 (X11; Linux armv7l; rv:2.0b4pre) Gecko/20100812 Firefox/4.0b4pre Fennec/2.0a1pre");
            UAgent.Add("Mozilla/5.0 (X11; Linux armv7l; rv:2.0b3pre) Gecko/20100730 Firefox/4.0b3pre Fennec/2.0a1pre");
            UAgent.Add("Mozilla/5.0 (X11; Linux armv71; en-US; rv:2.0b2pre) Gecko/20100722 Firefox/4.0b2pre Fennec/2.0a1pre");
            /*Firebird*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.6b) Gecko/20031212 Firebird/0.7+");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.6a) Gecko/20031002 Firebird/0.7");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.5) Gecko/20031007 Firebird/0.7");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; de-DE; rv:1.5) Gecko/20031007 Firebird/0.7");
            UAgent.Add("Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.5) Gecko/20031007 Firebird/0.7");
            /*Firefox*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.19) Gecko/20081202 Firefox (Debian-2.0.0.19-0etch1)");
            UAgent.Add("Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre");
            UAgent.Add("Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101213 Firefox/4.0b8pre");
            UAgent.Add("Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101128 Firefox/4.0b8pre");
            UAgent.Add("Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre");
            /*Flock*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.19) Gecko/2010061201 Firefox/3.0.19 Flock/2.6.0");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686 (x86_64); en-US; rv:1.9.0.16) Gecko/2009122206 Firefox/3.0.16 Flock/2.5.6");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.0.16) Gecko/2010021003 Firefox/3.0.16 Flock/2.5.6");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.7) Gecko/20091221 Firefox/3.5.7 Flock/2.5.6 (.NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.7) Gecko/20091221 AppleWebKit/531.21.8 KHTML/4.3.5 (like Gecko) Firefox/3.5.7 Flock/2.5.6 (.NET CLR 3.5.30729)");
            /*Fluid*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_1; nl-nl) AppleWebKit/532.3+ (KHTML, like Gecko) Fluid/0.9.6 Safari/532.3+");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_1; nl-nl) AppleWebKit/531.9 (KHTML, like Gecko) Fluid/0.9.6 Safari/531.9");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_6; en-us) AppleWebKit/528.16 (KHTML, like Gecko) Fluid/0.9.6 Safari/528.16");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/525.13 (KHTML, like Gecko) Fluid/0.9.4 Safari/525.13");
            /*Galaxy*/
            UAgent.Add("Galaxy/1.0 [en] (Mac OS X 10.5.6; U; en)");
            UAgent.Add("Galaxy/1.0 [en] (Mac OS X 10.5.6)");
            /*Galeon*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.8) Gecko/20090327 Galeon/2.0.7");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.8) Gecko Galeon/2.0.6 (Ubuntu 2.0.6-2)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.7) Gecko Galeon/2.0.6 (Debian 2.0.6-2.1)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.10) Gecko Galeon/2.0.6 (Ubuntu 2.0.6-2.1)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.16) Gecko/20080716 (Gentoo) Galeon/2.0.6");
            /*GranParadiso*/
            UAgent.Add("Mozilla/5.0(X11;U;Linux(x86_64);en;rv:1.9a8)Gecko/2007100619;GranParadiso/3.1");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux ppc; en-US; rv:1.9a8) Gecko/2007100620 GranParadiso/3.1");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux ppc; en-US; rv:1.9a8) Gecko/2007100620 GranParadiso/3.0a8");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9a7) Gecko/2007080210 GranParadiso/3.0a7");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9a5) Gecko/20070605 GranParadiso/3.0a5");
            /*GreenBrowser*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; WOW64; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.0.04506; Media Center PC 5.0; .NET CLR 3.5.21022; GreenBrowser)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30729; GreenBrowser)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.5.30729; InfoPath.2; .NET CLR 3.0.30729; GreenBrowser)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; OfficeLiveConnector.1.4; OfficeLivePatch.1.3; GreenBrowser)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; GTB6; .NET CLR 2.0.50727; GreenBrowser)");
            /*Hana*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/418.9 (KHTML, like Gecko) Hana/1.1");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/417.9 (KHTML, like Gecko) Hana/1.0");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; i386 Mac OS X; en) AppleWebKit/417.9 (KHTML, like Gecko) Hana/1.0");
            /*HotJava*/
            UAgent.Add("HotJava/1.1.2 FCS");
            UAgent.Add("HotJava/1.0.1/JRE1.1.x");
            /*IBM WebExplorer*/
            UAgent.Add("IBM WebExplorer /v0.94");
            /*IBrowse*/
            UAgent.Add("Mozilla/5.0 (compatible; IBrowse 3.0; AmigaOS4.0)");
            UAgent.Add("Mozilla/4.0 (compatible; IBrowse 2.3; AmigaOS4.0)");
            UAgent.Add("IBrowse/2.3 (AmigaOS 3.9)");
            /*iCab*/
            UAgent.Add("iCab/4.7 (Macintosh; U; Intel Mac OS X)");
            UAgent.Add("iCab/4.5 (Macintosh; U; PPC Mac OS X)");
            UAgent.Add("iCab/4.5 (Macintosh; U; Mac OS X Leopard 10.5.8)");
            UAgent.Add("iCab/4.5 (Macintosh; U; Mac OS X Leopard 10.5.7)");
            UAgent.Add("iCab/4.0 (Macintosh; U; Intel Mac OS X)");
            /*Iceape*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1.13) Gecko/20100916 Iceape/2.0.8");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1.11) Gecko/20100721 Iceape/2.0.6");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1.9) Gecko/20100502 Iceape/2.0.4");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux ppc; en-US; rv:1.8.1.13) Gecko/20080313 Iceape/1.1.9 (Debian-1.1.9-5)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.9) Gecko/20071030 Iceape/1.1.6 (Debian-1.1.6-3)");
            /*IceCat*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; it; rv:1.9.2.12) Gecko/20101114 IceCat/3.6.12 (like Firefox/3.6.12)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.3) Gecko/2008092921 IceCat/3.0.3-g1");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-CA; rv:1.9.0.3) Gecko/2008092921 IceCat/3.0.3-g1");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.2) Gecko/2008100722 IceCat/3.0.2-g1");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko/2008072716 IceCat/3.0.1-g1");
            /*Iceweasel*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; pt-PT; rv:1.9.2.3) Gecko/20100402 Iceweasel/3.6.3 (like Firefox/3.6.3) GTB7.0");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux 2.6.34.1-SquidSheep; en-US; rv:1.9.2.3) Gecko/20100402 Iceweasel/3.6.3 (like Firefox/3.6.3)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; pt-PT; rv:1.9.2.3) Gecko/20100402 Iceweasel/3.6 (like Firefox/3.6) GTB7.0");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; de-DE; rv:1.9.1.9) Gecko/20100501 Iceweasel/3.5.9 (like Firefox/3.5.9)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; ja; rv:1.9.1.8) Gecko/20100324 Iceweasel/3.5.8 (like Firefox/3.5.8)");
            /*iNet Browser*/
            UAgent.Add("Mozilla/5.0 (Future Star Technologies Corp.; Star-Blade OS; x86_64; U; en-US) iNet Browser 4.7");
            UAgent.Add("Mozilla/6.0 (Future Star Technologies Corp. Star-Blade OS; U; en-US) iNet Browser 2.5");
            /*Internet Explorer*/
            UAgent.Add("Mozilla/5.0 (Windows; U; MSIE 9.0; WIndows NT 9.0; en-US))");
            UAgent.Add("Mozilla/5.0 (Windows; U; MSIE 9.0; Windows NT 9.0; en-US)");
            UAgent.Add("Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; Media Center PC 6.0; InfoPath.3; MS-RTC LM 8; Zune 4.7)");
            UAgent.Add("Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; Zune 4.0; InfoPath.3; MS-RTC LM 8; .NET4.0C; .NET4.0E)");
            UAgent.Add("Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET CLR 2.0.50727; Media Center PC 6.0)");
            /*iRider*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/4.0; iRider 2.60.0008; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; iRider 2.21.1108)");
            /*Iron*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Iron/7.0.520.1 Chrome/7.0.520.1 Safari/534.7");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Iron/7.0.520.1 Safari/534.7");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Iron/7.0.520.1 Chrome/7.0.520.1 Safari/534.7");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Iron/7.0.520.0 Chrome/7.0.520.0 Safari/534.7");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/534.7 (KHTML, like Gecko) Iron/7.0.520.0 Chrome/7.0.520.0 Safari/534.7");
            /*K-Meleon*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; pl-PL; rv:1.8.1.24pre) Gecko/20100228 K-Meleon/1.5.4");
            UAgent.Add("Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.24pre) Gecko/20091010 K-Meleon/1.5.4");
            UAgent.Add("Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.24) Gecko/20100228 K-Meleon/1.5.4");
            UAgent.Add("Mozilla/5.0 (Windows; U; Win98; de-DE; rv:1.8.1.24) Gecko/20100228 K-Meleon/1.5.4");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.21) Gecko/20090331 K-Meleon/1.5.3");
            /*K-Ninja*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.4pre) Gecko/20070404 K-Ninja/2.1.3");
            UAgent.Add("Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.4pre) Gecko/20070404 K-Ninja/2.1.3");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.2pre) Gecko/20070215 K-Ninja/2.1.1");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.0.7) Gecko/20060917 K-Ninja/2.0.4");
            UAgent.Add("Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.0.7) Gecko/20060917 K-Ninja/2.0.4");
            /*Kapiko*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.0.1) Gecko/20080722 Firefox/3.0.1 Kapiko/3.0");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9) Gecko/20080705 Firefox/3.0 Kapiko/3.0");
            /*Kazehakase*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.0.7) Gecko Kazehakase/0.5.6");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.8) Gecko Fedora/1.9.0.8-1.fc10 Kazehakase/0.5.6");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.7) Gecko Kazehakase/0.5.6");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.1) Gecko Kazehakase/0.5.5");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.0.7) Gecko Kazehakase/0.5.4 Debian/0.5.4-2.2");
            /*KKman*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; KKMAN3.2; InfoPath.2; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; KKMAN3.2; .NET CLR 1.1.4322; .NET CLR 3.0.04506.30; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; InfoPath.1)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; KKMAN3.2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; KKMAN3.2; InfoPath.1)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; KKMAN3.2)");
            /*KMLite*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.19) Gecko/20081217 KMLite/1.1.2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.8.1.19) Gecko/20081217 KMLite/1.1.2");
            /*Konqueror*/
            UAgent.Add("Mozilla/5.0 (compatible; Konqueror/4.4; Linux) KHTML/4.4.1 (like Gecko) Fedora/4.4.1-1.fc12");
            UAgent.Add("Mozilla/5.0 (compatible; Konqueror/4.4; Linux 2.6.32-22-generic; X11; en_US) KHTML/4.4.3 (like Gecko) Kubuntu");
            UAgent.Add("Mozilla/5.0 (compatible; Konqueror/4.3; Linux) KHTML/4.3.1 (like Gecko) Fedora/4.3.1-3.fc11");
            UAgent.Add("Mozilla/5.0 (compatible; Konqueror/4.3; Linux 2.6.31-16-generic; X11) KHTML/4.3.2 (like Gecko)");
            UAgent.Add("Mozilla/5.0 (compatible; Konqueror/4.2; Linux; X11; x86_64) KHTML/4.2.4 (like Gecko) Fedora/4.2.4-2.fc11");
            /*LeechCraft*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; ru-RU) AppleWebKit/533.3 (KHTML, like Gecko) Leechcraft/0.4.55-13-g2230d9f Safari/533.3");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; ru-RU) AppleWebKit/533.3 (KHTML, like Gecko) Leechcraft/0.3.95-1-g84cc6b7 Safari/533.3");
            UAgent.Add("LeechCraft (X11; U; Linux; ru_RU) (LeechCraft/Poshuku 0.3.95-1-g84cc6b7; WebKit 4.7.1/4.7.1)");
            UAgent.Add("LeechCraft (X11; U; Linux; ru_RU) (LeechCraft/Poshuku 0.3.70-367-g174858a; WebKit 4.7.1/4.7.1)");
            UAgent.Add("LeechCraft (X11; U; Linux; ru_RU) (LeechCraft/Poshuku 0.3.70-325-gb4f750b; WebKit 4.7.1/4.7.1)");
            /*Links*/
            UAgent.Add("Links (6.9; Unix 6.9-astral sparc; 80x25)");
            UAgent.Add("Links (2.xpre7; Linux 2.4.18 i586; x)");
            UAgent.Add("Links (2.3pre1; Linux 2.6.35-22-generic i686; 177x51)");
            UAgent.Add("Links (2.2; OpenBSD 4.8 i386; x)");
            UAgent.Add("Links (2.2; NetBSD 5.0 i386; 80x25)");
            /*Lobo*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows XP 5.1) Lobo/0.98.4");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Linux 2.6.26-1-amd64) Lobo/0.98.3");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; U; Windows;) Lobo/0.98.2");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; U; Windows;) Lobo/0.98");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; U; Windows;) Lobo/0.97.5");
            /*lolifox*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.2) Gecko/20070225 lolifox/0.32");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.8pre) Gecko/20071012 lolifox/0.3.6 Firefox/2.0.0.7 compatible");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.2) Gecko/20070224 lolifox/0.3.2 MEGAUPLOAD 1.0");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.2) Gecko/20070224 lolifox/0.3.2");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.8.1) Gecko/20061127 lolifox/0.3.0");
            /*Lorentz*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.3pre) Gecko/20100403 Lorentz/3.6.3plugin2pre (.NET CLR 4.0.20506)");
            /*Lunascape*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; Lunascape 6.3.2.22803)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.11) Gecko/20100821 Firefox/3.5.11 Lunascape/6.3.1.22729");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.1.11) Gecko/20100723 Firefox/3.5.11 Lunascape/6.2.1.22445 ( .NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.1.10) Gecko/20100624 Firefox/3.5.10 Lunascape/6.2.0.22177 ( .NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.1.10) Gecko/20100624 Firefox/3.5.10 Lunascape/6.2.0.22177");
            /*Lynx*/
            UAgent.Add("Lynx (textmode)");
            UAgent.Add("Lynxy/6.6.6dev.8 libwww-FM/3.14159FM");
            UAgent.Add("Lynx/2.8.7dev.9 libwww-FM/2.14");
            UAgent.Add("Lynx/2.8.7dev.4 libwww-FM/2.14 SSL-MM/1.4.1 OpenSSL/0.9.8d");
            UAgent.Add("Lynx/2.8.6rel.5 libwww-FM/2.14 SSL-MM/1.4.1 OpenSSL/0.9.8g");
            /*Madfox*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en; rv:1.7.12) Gecko/20050928 Firefox/1.0.7 Madfox/3.0");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.7.12) Gecko/20051001 Firefox/1.0.7 Madfox/0.3.2u3");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.7.7) Gecko/20050503 Firefox/1.0.3 Madfox/0.3.2");
            /*Maxthon*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; chromeframe; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; MAXTHON 2.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; Maxthon 2.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618; MAXTHON 2.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0; .NET CLR 3.5.30729; .NET CLR 3.0.30618; MAXTHON 2.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; Trident/4.0; MAXTHON 2.0)");
            /*Midori*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; fr-fr) AppleWebKit/525.1+ (KHTML, like Gecko, Safari/525.1+) midori/1.19");
            UAgent.Add("Midori/0.2.2 (X11; Linux i686; U; fr-ca) WebKit/531.2+");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; pt-br; rv:1.8.1) Gecko/20061010 Firefox/2.0 Midori/0.2.0");
            UAgent.Add("Mozilla/5.0 (iPhone; U; Linux i686; pt-br) AppleWebKit/532+ (KHTML, like Gecko) Version/3.0 Mobile/1A538b Safari/419.3 Midori/0.2.0");
            UAgent.Add("Midori/0.2.0 (X11; Linux i686; U; pt-br) WebKit/531.2+");
            /*Minefield*/
            UAgent.Add("Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b4pre) Gecko/20100815 Minefield/4.0b4pre");
            UAgent.Add("Mozilla/5.0 (X11; Linux x86_64; en-US; rv:2.0b2pre) Gecko/20100712 Minefield/4.0b2pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:2.0a1pre) Gecko/2008060602 Minefield/4.0a1pre");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:2.0a1pre) Gecko/2008032002 Minefield/4.0a1pre");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:2.0a1pre) Gecko/2008032902 Minefield/4.0a1pre");
            /*Minimo*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux arm7tdmi; rv:1.8.1.11) Gecko/20071130 Minimo/0.025");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux arm7tdmi; rv:1.8.1.8) Gecko/20071018 Minimo/0.024");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux armv6l; rv: 1.8.1.5pre) Gecko/20070619 Minimo/0.020");
            UAgent.Add("Mozilla/5.0 (Windows; Windows; U; Windows NT 5.1; Windows CE 5.2; rv:1.8.1.4pre) Gecko/20070327 Minimo/0.020");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows CE 5.2; rv:1.8.1.4pre) Gecko/20070327 Minimo/0.020");
            /*Mozilla*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:2.0b4) Gecko/20100818");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9a3pre) Gecko/20070330");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.9.2a1pre) Gecko");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; pl; rv:1.9.2.3) Gecko/20100401 Lightningquail/3.6.3");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.1b3) Gecko/20090305");
            /*MultiZilla*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.4; MultiZilla v1.5.0.1) Gecko/20030624");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.4; MultiZilla v1.5.0.0f) Gecko/20030624");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.0; en-US; rv:1.3; MultiZilla v1.4.0.3J) Gecko/20030312");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.3; MultiZilla v1.4.0.3e) Gecko/20030312");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.2.1; MultiZilla v1.1.32 final) Gecko/20021130");
            /*MyIE2*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; MyIE2; SLCC1; .NET CLR 2.0.50727; Media Center PC 5.0)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; SV1; MyIE2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; WinFX RunTime 3.0.50727)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; MyIE2; InfoPath.2)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; MyIE2; InfoPath.1; .NET CLR 2.0.50727; .NET CLR 1.1.4322; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; MyIE2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
            /*Namoroka*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a2pre) Gecko/20090908 Ubuntu/9.04 (jaunty) Namoroka/3.6a2pre GTB5 (.NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a2pre) Gecko/20090901 Ubuntu/9.10 (karmic) Namoroka/3.6a2pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a2pre) Gecko/20090824 Ubuntu/9.10 (karmic) Namoroka/3.6a2pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a2pre) Gecko/20090817 Ubuntu/9.04 (jaunty) Namoroka/3.6a2pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; cs-CZ; rv:1.9.2a2pre) Gecko/20090826 Namoroka/3.6a2pre");
            /*NCSA_Mosaic*/
            UAgent.Add("NCSA Mosaic/3.0 (Windows 95)");
            UAgent.Add("NCSA_Mosaic/2.7b4 (X11;AIX 1 000180663000)");
            UAgent.Add("CSA_Mosaic/2.6 (X11; SunOS 4.1.3 sun4m)");
            UAgent.Add("NCSA_Mosaic/2.0 (Windows 3.1)");
            UAgent.Add("NCSA Mosaic/1.0 (X11;SunOS 4.1.4 sun4m)");
            /*NetNewsWire*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; de-de) AppleWebKit/531.22.7 (KHTML, like Gecko) NetNewsWire/3.2.7");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_2; de-de) AppleWebKit/531.21.8 (KHTML, like Gecko) NetNewsWire/3.2.3");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_7; de-de) AppleWebKit/525.28.3 (KHTML, like Gecko) NetNewsWire/3.1.7");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_6; de-de) AppleWebKit/525.27.1 (KHTML, like Gecko) NetNewsWire/3.1.7");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_5; en-us) AppleWebKit/525.18 (KHTML, like Gecko) NetNewsWire/3.1.7");
            /*NetPositive*/
            UAgent.Add("Mozilla/3.0 (compatible; NetPositive/2.2.2; BeOS)");
            UAgent.Add("Mozilla/3.0 (compatible; NetPositive/2.2)");
            UAgent.Add("Mozilla/3.0 (compatible; NetPositive/2.1.1; BeOS)");
            /*Netscape*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.8.1.8pre) Gecko/20070928 Firefox/2.0.0.7 Navigator/9.0RC1");
            UAgent.Add("Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.8pre) Gecko/20070928 Firefox/2.0.0.7 Navigator/9.0RC1");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en-US; rv:1.8.1.8pre) Gecko/20071001 Firefox/2.0.0.7 Navigator/9.0RC1");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.8.1.7pre) Gecko/20070815 Firefox/2.0.0.6 Navigator/9.0b3");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.2; en-US; rv:1.8.1.7pre) Gecko/20070815 Firefox/2.0.0.6 Navigator/9.0b3");
            /*NetSurf*/
            UAgent.Add("NetSurf/2.0 (RISC OS; armv5l)");
            UAgent.Add("NetSurf/2.0 (RISC OS; armv3l)");
            UAgent.Add("NetSurf/2.0 (Linux; i686)");
            UAgent.Add("NetSurf/1.2 (RISC OS; armv4l)");
            UAgent.Add("NetSurf/1.2 (NetBSD; i386; NetBSD 4.99.59 i386)");
            /*OmniWeb*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en-US) AppleWebKit/528.16 (KHTML, like Gecko, Safari/528.16) OmniWeb/v622.8.0.112941");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel 80486Mac OS X; en-US) AppleWebKit/528.16 (KHTML, like Gecko, Safari/528.16) OmniWeb/v622.8.0.112916");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_7; en-US) AppleWebKit/530.18+(KHTML, like Gecko, Safari/528.16) OmniWeb/v622.8.0");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_7; en-US) AppleWebKit/528.16+(KHTML, like Gecko, Safari/528.16) OmniWeb/v622.8.0");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_7; en-US) AppleWebKit/528.16 (KHTML, like Gecko, Safari/528.16) OmniWeb/v622.8.0");
            /*Opera*/
            UAgent.Add("Opera/9.99 (Windows NT 5.1; U; pl) Presto/9.9.9");
            UAgent.Add("Opera/9.80 (J2ME/MIDP; Opera Mini/5.0 (Windows; U; Windows NT 5.1; en) AppleWebKit/886; U; en) Presto/2.4.15");
            UAgent.Add("Opera/9.70 (Linux ppc64 ; U; en) Presto/2.2.1");
            UAgent.Add("Opera/9.70 (Linux i686 ; U; zh-cn) Presto/2.2.0");
            UAgent.Add("Opera/9.70 (Linux i686 ; U; en-us) Presto/2.2.0");
            /*Opera Mini*/
            UAgent.Add("Opera/10.61 (J2ME/MIDP; Opera Mini/5.1.21219/19.999; en-US; rv:1.9.3a5) WebKit/534.5 Presto/2.6.30");
            UAgent.Add("Opera/9.80 (Android; Opera Mini/5.1.21126/19.892; U; de) Presto/2.5.25");
            UAgent.Add("Opera/9.80 (J2ME/MIDP; Opera Mini/5.1.21051/20.2477; U; en) Presto/2.5.25");
            UAgent.Add("Opera/9.80 (J2ME/MIDP; Opera Mini/5.0.3521/886; U; en) Presto/2.4.15");
            UAgent.Add("Opera/9.80 (J2ME/MIDP; Opera Mini/5.0.3521/18.684; U; en) Presto/2.4.15");
            /*Opera Mobi*/
            UAgent.Add("Opera/9.80 (Windows NT 6.1; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UAgent.Add("Opera/9.80 (Windows NT 6.0; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UAgent.Add("Opera/9.80 (Windows NT 5.1; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UAgent.Add("Opera/9.80 (Windows Mobile; WCE; Opera Mobi/49; U; en) Presto/2.4.18 Version/10.00");
            UAgent.Add("Opera/9.80 (Macintosh; Intel Mac OS X; Opera Mobi/3730; U; en) Presto/2.4.18 Version/10.00");
            /*Orca*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.1.1) Gecko/20090722 Firefox/3.5.1 Orca/1.2 build 2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.1.1) Gecko/20090722 Firefox/3.5.1 Orca/1.2 build 2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.0.7) Gecko/2009030821 Firefox/3.0.7 Orca/1.1 build 2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.7) Gecko/2009030821 Firefox/3.0.7 Orca/1.1 build 2");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.6) Gecko/2009022300 Firefox/3.0.6 Orca/1.1 build 1");
            /*Oregano*/
            UAgent.Add("Mozilla/1.10 [en] (Compatible; RISC OS 3.70; Oregano 1.10)");
            UAgent.Add("Mozilla/1.10 [en] (Compatible; RISC OS 3.70; Oregano 1.10)");
            /*Palemoon*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; ja-JP; rv:1.9.2.3) Gecko/20100403 Firefox/3.6.3 (Palemoon/3.6.3)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.3) Gecko/20100403 Firefox/3.6.3 (Palemoon/3.6.3)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.3) Gecko/20100403 Firefox/3.6.3 (Palemoon/3.6.3) (.NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; ja-JP; rv:1.9.2.3) Gecko/20100403 Firefox/3.6.3 (Palemoon/3.6.3) GTB7.0 (.NET CLR 3.5.30729)");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; ja-JP; rv:1.9.2.3) Gecko/20100403 Firefox/3.6.3 (Palemoon/3.6.3) (.NET CLR 3.5.30729)");
            /*Phoenix*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.3a) Gecko/20021207 Phoenix/0.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; WinNT4.0; en-US; rv:1.3a) Gecko/20021207 Phoenix/0.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.4a) Gecko/20030411 Phoenix/0.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.3a) Gecko/20021207 Phoenix/0.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; de-DE; rv:1.3a) Gecko/20021207 Phoenix/0.5");
            /*Pogo*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.13) Gecko/20080414 Firefox/2.0.0.13 Pogo/2.0.0.13.6866");
            /*Prism*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; en-US; rv:1.9.2.3) Gecko/20100402 Prism/1.0b4");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2pre) Gecko/20100115 Prism/1.0b3");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.7) Gecko/20091221 Firefox/3.5.7 Prism/1.0b2");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.0.17) Gecko/2010010604 prism/0.8");
            /*QtWeb Internet Browser*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/527+ (KHTML, like Gecko) QtWeb Internet Browser/3.0 http://www.QtWeb.net");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/527+ (KHTML, like Gecko) QtWeb Internet Browser/2.0 http://www.QtWeb.net");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US) AppleWebKit/527+ (KHTML, like Gecko) QtWeb Internet Browser/1.7 http://www.QtWeb.net");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; es-CO) AppleWebKit/527+ (KHTML, like Gecko) QtWeb Internet Browser/1.7 http://www.QtWeb.net");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/527+ (KHTML, like Gecko) QtWeb Internet Browser/1.7 http://www.QtWeb.net");
            /*retawq*/
            UAgent.Add("retawq/0.2.6c [en] (text)");
            /*Safari*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-HK) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) AppleWebKit/533.19.4 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; tr-TR) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; nb-NO) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; fr-FR) AppleWebKit/533.18.1 (KHTML, like Gecko) Version/5.0.2 Safari/533.18.5");
            /*SeaMonkey*/
            UAgent.Add("Seamonkey-1.1.13-1(X11; U; GNU Fedora fc 10) Gecko/20081112");
            UAgent.Add("Mozilla/5.0 (Windows; Windows NT 5.2; rv:2.0b3pre) Gecko/20100803 SeaMonkey/2.1a3pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.3a4pre) Gecko/20100404 SeaMonkey/2.1a1pre");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.2; en-CA; rv:1.9.3a3pre) Gecko/20100312 SeaMonkey/2.1a1pre");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.2pre) Gecko/20090723 SeaMonkey/2.0b2pre");
            /*Shiira*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; ja-jp) AppleWebKit/419 (KHTML, like Gecko) Shiira/1.2.3 Safari/125");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en_CA) AppleWebKit/522+ (KHTML, like Gecko) Shiira/1.2.3 Safari/125");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/419 (KHTML, like Gecko) Shiira/1.2.3 Safari/125");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/522.10.1 (KHTML, like Gecko) Shiira/1.2.2 Safari/125");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/419 (KHTML, like Gecko) Shiira/1.2.2 Safari/125");
            /*Shiretoko*/
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1b5pre) Gecko/20090424 Shiretoko/3.5b5pre");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.1b5pre) Gecko/20090519 Shiretoko/3.5b5pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1b4pre) Gecko/20090404 Shiretoko/3.5b4pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1b4pre) Gecko/20090401 Ubuntu/9.04 (jaunty) Shiretoko/3.5b4pre");
            UAgent.Add("Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1b4pre) Gecko/20090405 Shiretoko/3.5b4pre");
            /*Sleipnir*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.2; Sleipnir/2.9.6)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; GTB0.0; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 1.1.4322; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; OfficeLiveConnector.1.3; OfficeLivePatch.0.0; Sleipnir/2.9.6)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; WOW64; Trident/4.0; SLCC1; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Sleipnir/2.9.4)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; InfoPath.1; Sleipnir/2.9.4)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022; InfoPath.2; Sleipnir/2.9.3)");
            /*SlimBrowser*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; SlimBrowser)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; SlimBrowser)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; .NET CLR 2.0.50727; SlimBrowser)");
            /*Stainless*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_6; en-us) AppleWebKit/528.16 (KHTML, like Gecko) Stainless/0.5.3 Safari/525.20.1");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_6; es-es) AppleWebKit/525.27.1 (KHTML, like Gecko) Stainless/0.4.5 Safari/525.20.1");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_5; zh-tw) AppleWebKit/525.27.1 (KHTML, like Gecko) Stainless/0.4.5 Safari/525.20.1");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_5; en-us) AppleWebKit/525.27.1 (KHTML, like Gecko) Stainless/0.4.5 Safari/525.20.1");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_5; zh-tw) AppleWebKit/525.27.1 (KHTML, like Gecko) Stainless/0.4 Safari/525.20.1");
            /*Sunrise*/
            UAgent.Add("Mozilla/6.0 (X11; U; Linux x86_64; en-US; rv:2.9.0.3) Gecko/2009022510 FreeBSD/ Sunrise/4.0.1/like Safari");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_5; ja-jp) AppleWebKit/525.18 (KHTML, like Gecko) Sunrise/1.7.5 like Safari/5525.20.1");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_4_11; en) AppleWebKit/525.18 (KHTML, like Gecko) Sunrise/1.7.4 like Safari/4525.22");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_2; en-us) AppleWebKit/525.18 (KHTML, like Gecko) Sunrise/1.7.1 like Safari/5525.18");
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en) AppleWebKit/418.9.1 (KHTML, like Gecko) Sunrise/1.6.5 like Safari/419.3");
            /*TeaShark*/
            UAgent.Add("Mozilla/5.0 (Macintosh; U; Intel Mac OS X; en) AppleWebKit/418.9.1 (KHTML, like Gecko) Safari/419.3 TeaShark/0.8");
            /*uZard Web*/
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; WOW64; Trident/4.0; uZardWeb/1.0; Server_USA)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; WOW64; Trident/4.0; uZardWeb/1.0; Server_KO_KTF)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.2; WOW64; Trident/4.0; uZard/1.0; Server_KO_SKT)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; WOW64; SV1; uZardWeb/1.0; Server_HK)");
            UAgent.Add("Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; WOW64; SV1; uZardWeb/1.0; Server_EN)");
            /*uzbl*/
            UAgent.Add("Webkit/1.1.8 (Linux; en_US) Uzbl");
            UAgent.Add("Webkit/1.1.8 (Linux; en-us) Uzbl");
            UAgent.Add("Uzbl (X11; U; Arch Linux; de-DE) Webkit/1.1.10");
            UAgent.Add("Uzbl (X11; U; Arch Linux i686; de-DE) Webkit/1.1.10");
            UAgent.Add("Uzbl (Webkit 1.1.9) (Linux)");
            /*Vonkeror*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1pre) Gecko/20090629 Vonkeror/1.0");
            /*w3m*/
            UAgent.Add("w3m/0.52");
            UAgent.Add("w3m/0.5.2");
            UAgent.Add("w3m/0.5.1+cvs-1.968");
            UAgent.Add("w3m/0.5.1");
            UAgent.Add("w3m/0.2.1");
            /*WorldWideWeb*/
            UAgent.Add("WorldWideweb (NEXT)");
            /*Wyzo*/
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.1.6) Gecko/20100121 Firefox/3.5.6 Wyzo/3.5.6.1");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.6) Gecko/20100121 Firefox/3.5.6 Wyzo/3.5.6");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.0.10) Gecko/2009042815 Firefox/3.0.10 Wyzo/3.0.4");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.0.9) Gecko/2009042410 Firefox/3.0.9 Wyzo/3.0.3");
            UAgent.Add("Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.0.9) Gecko/2009042410 Firefox/3.0.9 Wyzo/3.0.3");
        }
        public int Count()
        {
            return UAgent.Count;
        }
        public string GetUA()
        {
            Random rnd = new Random();
            return UAgent[rnd.Next(this.Count()) - 1];
        }
    }
}
