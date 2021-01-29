using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using tpns;


class Program
{
    static void Main(string[] args)
    {
        //android
        //uint accessId = 1500001533;
        //string secretKey = "euwhfy3zyi3hvahkf60y0c2xx3wlpsz1";
        //string android_token = "038f7011515ffff9e8337864873cd83d271c";
        //string android_tag = "guoqing_a";
        //string android_account = "guoqing_a";
        
        ////tag_rules
        //var tagItem1 = new TagRule.TagItem();
        //tagItem1.tags = new List<string>();
        //tagItem1.tags.Add("guoqing_a");
        //tagItem1.tagsOperator = Constants.TAG_OPERATOR_OR;
        //tagItem1.itemsOperator = Constants.TAG_OPERATOR_OR;
        //tagItem1.tagType = "xg_user_define";

        //var tagItem2 = new TagRule.TagItem();
        //tagItem2.tags = new List<string>();
        //tagItem2.tags.Add("guangdong");
        //tagItem2.tagsOperator = Constants.TAG_OPERATOR_OR;
        //tagItem2.itemsOperator = Constants.TAG_OPERATOR_AND;
        //tagItem2.tagType = "xg_auto_province";

        //var tagRule = new TagRule();
        //tagRule.tagItems = new List<TagRule.TagItem>();
        //tagRule.tagItems.Add(tagItem1);
        //tagRule.tagItems.Add(tagItem2);
        //tagRule.Operator = Constants.TAG_OPERATOR_OR;
        //var tag_rules = new List<TagRule>();
        //tag_rules.Add(tagRule);

        ////token
        //var token_list = new List<string>();
        //token_list.Add(android_token);
        ////account
        //var account_list = new List<string>();
        //account_list.Add(android_account);

        //ios
        uint accessId = 1600001061;
        string secretKey = "662273e0c8b9f3dc653778378d2eef4a";
        string ios_token = "0717adb33556e84169f942ac86f776c9ce2d";
        string ios_tag = "a";
        string ios_account = "a";

        //tag_rules
        var tagItem1 = new TagRule.TagItem();
        tagItem1.tags = new List<string>();
        tagItem1.tags.Add("a");
        tagItem1.tagsOperator = Constants.TAG_OPERATOR_OR;
        tagItem1.itemsOperator = Constants.TAG_OPERATOR_OR;
        tagItem1.tagType = "xg_user_define";

        var tagItem2 = new TagRule.TagItem();
        tagItem2.tags = new List<string>();
        tagItem2.tags.Add("guangdong");tagItem2.tags.Add("shanghai");
        tagItem2.tagsOperator = Constants.TAG_OPERATOR_OR;
        tagItem2.itemsOperator = Constants.TAG_OPERATOR_AND;
        tagItem2.tagType = "xg_auto_province";

        var tagRule = new TagRule();
        tagRule.tagItems = new List<TagRule.TagItem>();
        tagRule.tagItems.Add(tagItem1);
        tagRule.tagItems.Add(tagItem2);
        tagRule.Operator = Constants.TAG_OPERATOR_OR;
        var tag_rules = new List<TagRule>();
        tag_rules.Add(tagRule);

        //token
        var token_list = new List<string>();
        token_list.Add(ios_token);
        //account
        var account_list = new List<string>();
        account_list.Add(ios_account);


        // push
        var stub = new Stub(accessId, secretKey, Host.Guangzhou);

        // android push_token
        //var push_token_req = new tpns.Request();
        //push_token_req.audienceType = tpns.Constants.AUDIENCE_TOKEN;
        //push_token_req.platform = tpns.Constants.PLATFORM_ANDROID;
        //push_token_req.messageType = tpns.Constants.MESSAGE_NOTIFY;
        //var token_list = new List<string>();
        //token_list.Add(android_token);
        //push_token_req.tokenList = token_list;
        //var push_token_msg = new tpns.Message();
        //push_token_msg.title = "Csharp_push_token";
        //push_token_msg.content = "Csharp_push_token";
        //push_token_req.message = push_token_msg;
        //to json
        //string push_token_data = JsonConvert.SerializeObject(push_token_req);
        //Console.WriteLine(push_token_data);
        ////push tokoen
        //var push_token_resp = stub.Push(push_token_req);

        //Console.Write(push_token_resp.ret_code + " " + push_token_resp.err_msg + "\n");
        //Console.Write(push_token_resp.push_id + " " + push_token_resp.result + "\n");

        //android push_token args
        //var token_args = new tpns.Request();
        //token_args.audienceType = tpns.Constants.AUDIENCE_TOKEN;
        //token_args.platform = tpns.Constants.PLATFORM_ANDROID;
        //token_args.messageType = tpns.Constants.MESSAGE_NOTIFY;

        //var tokens_lists = new List<string>();
        //tokens_lists.Add(android_token);
        ////token_list.Add("abc");
        //token_args.tokenList = tokens_lists;

        //// tpns/Message
        //var token_msg = new tpns.Message();
        ////tile content
        //token_msg.title = "Csharp_push_token";
        //token_msg.content = "Csharp_push_token";
        ////accepttime  tpns AcceptTimeRange
        //var accepttime_rng = new tpns.AcceptTimeRange();
        //// tpns AcceptTime
        //var acpt_time_start = new tpns.AcceptTimeRange.AcceptTime();
        //acpt_time_start.hour = "08";
        //acpt_time_start.min = "00";
        //var acpt_time_end = new tpns.AcceptTimeRange.AcceptTime();
        //acpt_time_end.hour = "20";
        //acpt_time_end.min = "00";
        //accepttime_rng.start = acpt_time_start;
        //var accept_time = new List<AcceptTimeRange>();
        //accept_time.Add(accepttime_rng);
        //token_msg.acceptTime = accept_time;
        ////thread_id
        //token_msg.threadId = "cSharp";
        ////thread_sumtext
        //token_msg.threadSumText = "cSharp sdk";
        ////xg_media_resources
        //token_msg.xgMediaResources = "http://www.irunthink.com/data/attachment/portal/201803/17/220624v69o506onn12soud.jpg";
        ////xg_media_audio_resources
        //token_msg.xgMediaAudioResources = "https://v-cdn.zjol.com.cn/277003.mp4";
        ////android
        //var android_args = new tpns.AndroidMessage();

        ////android action
        //var android_action = new tpns.AndroidMessage.Action();
        //android_action.actionType = 1;
        //android_action.activity = "com.tencent.android.duoduo.JumpActivity";

        //// action ActivityAttribute
        //var action_attr = new AndroidMessage.Action.ActivityAttribute();
        //action_attr.iff = 2;
        //action_attr.pf = 1;
        //android_action.activityAttr = action_attr;
        ////action BrowserAttribute
        //var br = new tpns.AndroidMessage.Action.BrowserAttribute();
        //br.confirm = 1;
        //br.url = "http://www.qq.com";
        //android_action.browser = br;
        ////action intent
        //android_action.intent = "tpns://android.intent.action.VIEW";
        ////n_ch_id
        //android_args.chId = "c#";
        ////n_ch_name
        //android_args.chName = "c# sdk";
        ////xm_ch_id
        //android_args.xmChId = "xm";
        ////hw_ch_id
        //android_args.hwChId = "hw";
        ////oppo_ch_id
        //android_args.oppoChId = "oppo";
        ////vivo_ch_id
        //android_args.vivoChId = "vivo";
        ////builder_id
        //android_args.buildId = 1;
        ////badge_type
        //android_args.badgeType = -2;
        ////ring
        //android_args.ring = 1;
        ////ring_raw
        //android_args.ringRaw = "xg_ring";
        ////vibrate
        //android_args.vibrate = 1;
        ////lights
        //android_args.lights = 1;
        ////clearable
        //android_args.clearable = 1;
        ////icon_type
        //android_args.iconType = 1;
        ////icon_res
        //android_args.iconRes = "http://www.irunthink.com/data/attachment/portal/201803/17/220624v69o506onn12soud.jpg";
        ////style_id
        //android_args.styleId = 1;
        ////small_icon
        //android_args.smallIcon = "http://www.irunthink.com/data/attachment/portal/201803/17/220624v69o506onn12soud.jpg";
        ////action
        //android_args.action = android_action;
        ////custom_content
        //android_args.customContent = "{\"key1\":\"value1\"}";
        ////show_type
        //android_args.showType = 1;
        ////icon_color
        //android_args.iconColor = 1;

        //token_msg.android = android_args;
        ////ios
        //var ios_args = new tpns.iOSMessage();

        //token_msg.ios = ios_args;
        //token_args.message = token_msg;

        ////to json
        ////string token_data = JsonConvert.SerializeObject(token_args);
        ////Console.WriteLine(token_data);
        ////push tokoen
        ////var token_rsp = stub.Push(token_args);

        ////Console.Write(token_rsp.ret_code + " " + token_rsp.err_msg + "\n");
        ////Console.Write(token_rsp.push_id + " " + token_rsp.result + "\n");

        ////environment
        //token_args.environment = "dev";
        ////upload_id
        //token_args.uploadId = 36217;
        ////expire_time
        //token_args.expireTime = 1600;
        ////send_time
        ////token_args.sendTime = "2021-01-27 16:30:00";
        ////multi_pkg
        //token_args.multiPkg = true;
        ////plan_id
        //token_args.planId = "15470";
        ////account_push_type
        //token_args.accountPushType = 1;
        ////collapse_id
        ////token_args.collapseId = 666666;
        ////push_speed
        //token_args.pushSpeed = 200000;
        ////tpns_online_push_type
        //token_args.tpnsOnlinePushType = 1;
        ////force_collapse
        //token_args.forceCollapse = true;
        ////channel_rules
        //var channel_rules = new tpns.ChannelRule();
        //channel_rules.channel = "xm";
        //channel_rules.disable = false;
        //var ch_rules = new List<tpns.ChannelRule>();
        //ch_rules.Add(channel_rules);
        //token_args.channelRules = ch_rules;
        ////loop_param
        //var loops = new tpns.LoopParam();
        //loops.startDate = "";
        //loops.endDate = "";
        //loops.loopType = 1;
        //var loops_day_index = new List<uint>();
        //loops_day_index.Add(1);loops_day_index.Add(2); loops_day_index.Add(3);
        //loops.loopDayIndexs = loops_day_index;
        //var day_times = new List<string>();
        //day_times.Add("16:40:00");day_times.Add("12:00:00");
        //loops.dayTimes = day_times;
        ////token_args.loopParam = loops;

        ////to json
        //string token_data2 = JsonConvert.SerializeObject(token_args);
        ////Console.WriteLine("request:\n");
        //Console.WriteLine(token_data2);
        ////push tokoen
        //var token_rsp2 = stub.Push(token_args);
        //Console.WriteLine("response:\n");
        //Console.Write(token_rsp2.ret_code + " " + token_rsp2.err_msg + "\n");
        //Console.Write(token_rsp2.push_id + " " + token_rsp2.result + "\n");

        //push token method with

        // tpns/Message
        var token_msg = new tpns.Message();
        //tile content
        token_msg.title = "Csharp_push_token";
        token_msg.content = "Csharp_push_token";
        //accepttime  tpns AcceptTimeRange
        var accepttime_rng = new tpns.AcceptTimeRange();
        // tpns AcceptTime
        var acpt_time_start = new tpns.AcceptTimeRange.AcceptTime();
        acpt_time_start.hour = "08";
        acpt_time_start.min = "00";
        var acpt_time_end = new tpns.AcceptTimeRange.AcceptTime();
        acpt_time_end.hour = "20";
        acpt_time_end.min = "00";
        accepttime_rng.start = acpt_time_start;
        var accept_time = new List<AcceptTimeRange>();
        accept_time.Add(accepttime_rng);
        token_msg.acceptTime = accept_time;
        //thread_id
        token_msg.threadId = "cSharp";
        //thread_sumtext
        token_msg.threadSumText = "cSharp sdk";
        //xg_media_resources
        token_msg.xgMediaResources = "http://www.irunthink.com/data/attachment/portal/201803/17/220624v69o506onn12soud.jpg";
        //xg_media_audio_resources
        token_msg.xgMediaAudioResources = "https://v-cdn.zjol.com.cn/277003.mp4";
        //android
        var android_args = new tpns.AndroidMessage();

        //android action
        var android_action = new tpns.AndroidMessage.Action();
        android_action.actionType = 1;
        android_action.activity = "com.tencent.android.duoduo.JumpActivity";

        // action ActivityAttribute
        var action_attr = new AndroidMessage.Action.ActivityAttribute();
        action_attr.iff = 2;
        action_attr.pf = 1;
        android_action.activityAttr = action_attr;
        //action BrowserAttribute
        var br = new tpns.AndroidMessage.Action.BrowserAttribute();
        br.confirm = 1;
        br.url = "http://www.qq.com";
        android_action.browser = br;
        //action intent
        android_action.intent = "tpns://android.intent.action.VIEW";
        //n_ch_id
        android_args.chId = "c#";
        //n_ch_name
        android_args.chName = "c# sdk";
        //xm_ch_id
        android_args.xmChId = "xm";
        //hw_ch_id
        android_args.hwChId = "hw";
        //oppo_ch_id
        android_args.oppoChId = "oppo";
        //vivo_ch_id
        android_args.vivoChId = "vivo";
        //builder_id
        android_args.buildId = 1;
        //badge_type
        android_args.badgeType = -2;
        //ring
        android_args.ring = 1;
        //ring_raw
        android_args.ringRaw = "xg_ring";
        //vibrate
        android_args.vibrate = 1;
        //lights
        android_args.lights = 1;
        //clearable
        android_args.clearable = 1;
        //icon_type
        android_args.iconType = 1;
        //icon_res
        android_args.iconRes = "http://www.irunthink.com/data/attachment/portal/201803/17/220624v69o506onn12soud.jpg";
        //style_id
        android_args.styleId = 1;
        //small_icon
        android_args.smallIcon = "http://www.irunthink.com/data/attachment/portal/201803/17/220624v69o506onn12soud.jpg";
        //action
        android_args.action = android_action;
        //custom_content
        android_args.customContent = "{\"key1\":\"value1\"}";
        //show_type
        android_args.showType = 1;
        //icon_color
        android_args.iconColor = 1;

        token_msg.android = android_args;
        //ios
        var ios_args = new tpns.iOSMessage();
        var ios_aps = new tpns.iOSMessage.Aps();
        var ios_alert = new Dictionary<string, string>();
        ios_alert.Add("subtitle", "c#_push");
        ios_aps.alert = ios_alert;
        ios_aps.badgeType = -2;
        ios_aps.category = "c# sdk";
        ios_aps.contentAvailable = 1;
        ios_aps.sound = "ring";
        ios_aps.mutableContent = 1;
        //ios aps
        ios_args.aps = ios_aps;
        ios_args.custom = "{\"key1\":\"value1\"}";

        token_msg.ios = ios_args;

        

        ////channel_rules
        var channel_rules = new tpns.ChannelRule();
        //channel_rules.channel = "xm";
        channel_rules.channel = "apns";
        channel_rules.disable = false;
        var ch_rules = new List<tpns.ChannelRule>();
        ch_rules.Add(channel_rules);


        ////loop_param
        var loops = new tpns.LoopParam();
        loops.startDate = "2021-01-28";
        loops.endDate = "2021-01-30";
        loops.loopType = 1;
        var loops_day_index = new List<uint>();
        loops_day_index.Add(1); loops_day_index.Add(2); loops_day_index.Add(3);
        loops.loopDayIndexs = loops_day_index;
        var day_times = new List<string>();
        day_times.Add("16:40:00"); day_times.Add("12:00:00");
        loops.dayTimes = day_times;

        var push_token = tpns.TPNs.NewRequest(
                //With.AudienceType(tpns.Constants.AUDIENCE_TOKEN_LIST),
                //With.AudienceType(tpns.Constants.AUDIENCE_ACCOUNT_LIST),
                //With.AudienceType(tpns.Constants.AUDIENCE_TAG),
                //With.AudienceType(tpns.Constants.AUDIENCE_ALL),
                //With.Platform(Constants.PLATFORM_ANDROID),
                With.Platform(Constants.PLATFORM_IOS),
                //With.AudienceType(tpns.Constants.AUDIENCE_TOKEN_LIST),
                With.AudienceType(tpns.Constants.AUDIENCE_ACCOUNT_LIST),
                //With.AudienceType(tpns.Constants.AUDIENCE_TAG),
                //With.Message(token_msg),
                With.Title("c#_push_account"),
                With.Content("c#_push_account"),
                With.AcceptTime(accept_time),
                With.ThreadId("c#"),
                With.ThreadSumText("c# sdk"),
                With.XGMediaResources("http://www.irunthink.com/data/attachment/portal/201803/17/220624v69o506onn12soud.jpg"),
                With.XGMediaAudioResources("https://v-cdn.zjol.com.cn/277003.mp4"),
                With.AndroidMessage(android_args),
                With.IOSMessage(ios_args),
                With.MessageType(Constants.MESSAGE_NOTIFY),
                With.TagRules(tag_rules),
                With.TokenList(token_list),
                With.AccountList(account_list),
                With.Environment("dev"),
                With.UploadId(66666),
                With.ExpireTime(1200),
                //With.SendTime("2021-01-28 11:37:00"),
                With.MultiPkg(true),
                //With.PlanId("15470"),
                With.AccountPushType(1),
                //With.CollapseId(66666),
                With.PushSpeed(20000),
                With.TpnsOnlinePushType(1),
                With.ForceCollapse(true),
                With.ChannelRules(ch_rules)
                //With.LoopParam(loops)
          );

        //
        ////to json
        string token_data2 = JsonConvert.SerializeObject(push_token);
        //Console.WriteLine("request:\n");
        Console.WriteLine(token_data2);
        //push tokoen
        var token_rsp2 = stub.Push(push_token);
        Console.WriteLine("response:\n");
        Console.Write(token_rsp2.retCode + " " + token_rsp2.errMsg + "\n");
        Console.Write(token_rsp2.pushId.ToString() + " " + token_rsp2.result + "\n");
        //foreach (string id in token_rsp2.pushId) {
        //    Console.Write(id+ "\n");
        //}


        //var ios = new iOSMessage();
        //ios.custom = "{\"key\":\"value\"}";

        //var tagItem1 = new TagRule.TagItem();
        //tagItem1.tags = new List<string>();
        //tagItem1.tags.Add("guangdong");
        //tagItem1.tags.Add("hunan");
        //tagItem1.tagsOperator = Constants.TAG_OPERATOR_OR;
        //tagItem1.itemsOperator = Constants.TAG_OPERATOR_OR;
        //tagItem1.tagType = "xg_auto_province";

        //var tagItem2 = new TagRule.TagItem();
        //tagItem2.tags = new List<string>();
        //tagItem2.tags.Add("20200408");
        //tagItem2.tagsOperator = Constants.TAG_OPERATOR_OR;
        //tagItem2.itemsOperator = Constants.TAG_OPERATOR_AND;
        //tagItem2.tagType = "xg_auto_active";



        //var tagRule = new TagRule();
        //tagRule.tagItems = new List<TagRule.TagItem>();
        //tagRule.tagItems.Add(tagItem1);
        //tagRule.tagItems.Add(tagItem2);
        //tagRule.Operator =  Constants.TAG_OPERATOR_OR;

        //var tagRules = new List<TagRule>();
        //tagRules.Add(tagRule);
        //var req = TPNs.NewRequest(
        //             With.AudienceType(Constants.AUDIENCE_TAG),
        //             With.MessageType(Constants.MESSAGE_NOTIFY),
        //             With.Platform(Constants.PLATFORM_IOS),
        //             With.Title("this-title"),
        //             With.Content("this-content"),
        //             With.TagRules(tagRules),
        //             With.Environment(Constants.ENVIRONMENT_DEV),
        //             With.IOSMessage(ios)
        //          );

        //string data = JsonConvert.SerializeObject(req);
        //Console.WriteLine(data);
        //push tag
        //var push_tag_resp = stub.Push(req);
        //Console.Write(push_tag_resp.ret_code.ToString() + " " + push_tag_resp.err_msg + "\n");
    }
}
