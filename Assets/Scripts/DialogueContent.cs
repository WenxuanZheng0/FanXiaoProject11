using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
///</summary>
public class DialogueContent : MonoBehaviour
{
    private string ChuFaDan1 = "一张遗落在教室中的处罚单，上面写满了被处罚的学生的名字，有一块被人为地用墨水污染了。\n除了学生本人，没人知道用来处罚学生的“戒尺”抽打在身上到底有多疼，被关在小黑屋到底有多么绝望……所以这也是一些学生家长到现在都不承认南青书院在虐待学生的原因之一？";
    private string ChuFaDan2 = "“我之前从来没有想过我都18岁了，还要脱下裤子来打屁股。那根像是钢筋做的“龙鞭”狠抽下来——我不想再回忆之前挨打的情形了……大家都在哭……”\n“幸亏南青书院已经查封了，幸亏幸亏……”";
    private List<string> ChuFaDanL = new List<string>();

    private string TongZhiShu1 = "从警方查获的资料中遗漏下来的病危通知单复印件，从纸上看到，是徐六的。\n吞食有毒物质导致的中毒，病危程度已经威胁生命。作为从南青书院“逃出”的学生，他的精神已经远非正常，恐惧和阴影使他夜不能寐，一天天的折磨让他决定自尽。";
    private string TongZhiShu2 = "可怜的徐六……我第一次见到他的时候他还是积极想办法出去的样子。我听说他之前还自尽了好几次未果，这次终于要……我也曾以为这样就能解决问题，但我坚持下来了……我要看着它倒！看着它离开我的梦！这样我才能得到真正的解脱！”\n“话说回来，不知道他现在怎么样了……”";
    private List<string> TongZhiShuL = new List<string>();

    private string XiaoDao1 = "一把餐刀，或许是从厨房偷出来的。\n曾经有人把它藏在鞋底，为了防范突然出现的“危险情况”。或许在这里，可能的“危险情况”每天都在发生，不过还好，偷出这把餐刀的人没有遇上那种机会，用它做出一些极端行为。";
    private string XiaoDao2 = "“我听一个和我一样选择回来作证的学生说：这是一个逼人拿起刀的地方。可我第一时间想到的，竟然是为了拿出这把刀，他到底挨了多少尺教鞭？”";
    private List<string> XiaoDaoL = new List<string>();

    private string XiaoGui1 = "一张肮脏的校规，正如它上面写的内容一样肮脏。\n事实上校规并没有完全写在上面，一方面是一张纸确实写不下那么多规定，另一方面，还有一些学生和教师间不成文的规定，是写不上这里的。不得不说，这张校规长得像是一个腐朽王国的“法律”一样，校长就是国王，他老婆是王后，学生们都是奴隶。";
    private string XiaoGui2 = "“多么讽刺，多么冠冕堂皇，从来没有这样的文字组合让我看得想吐。那条有关新生的，我刚进来的时候就被人安排着洗他们的内衣，还要‘主动’去承担打扫卫生。而且像我这样的女孩子在学校里根本没有人权，什么男尊女卑，打饭都要男生先去。有时候真的恍然隔世：这真的是现代社会吗？”\n“‘未嫁从父，既嫁从夫，夫死从子’……我真的讨厌我自己，竟然还记得这些文字！”";
    private List<string> XiaoGuiL = new List<string>();

    private string SuiPian1 = " 几块碎片。\n“虽说我不知道这是打碎什么的碎片，但我突然想起了那个总是不说话的姑娘。她是孔十儿，唯一一个没有欺负过我的姑娘。她刚来到这里的时候和我一样，被关在小黑屋中，美其名曰‘森田疗法’。";
    private string SuiPian2 = "那两天天气尤其不好，阴森森湿漉漉的，加上当时那间屋子停电，她被黑暗和蚁虫逼疯了，不知如何攀上墙拽下了空调，用摔碎的碎片划破了自己的手腕……她根本没有被送去抢救！他们就简单包扎包扎，继续把她关在那个暗无天日的破地方！”\n“她比我早出去一些，我记得她偷偷写了张字条给我：‘好像在废墟里待了很久，天终于亮了一点。’”";
    private List<string> SuiPianL = new List<string>();

    private string BaoZhi1 = "当天的报纸，头版头条是“南青书院终于被查封 大快人心”。\n 今日日报，本日的头版头条相关内容由四位特约记者编写，严肃讨论了有关南青书院虐待学生等相关违法行为，关于规范化网瘾防治的教育部批文的讨论，以及揭露了南青书院虐待学生的事实。这份报纸一时间闹得南青市沸沸扬扬，从来没有人关注的小门外挤满了围观的人群。";
    private string BaoZhi2 = "“我们终于等来了这一天。但愿相关责任人能尽数绳之以法，但愿世间能再无这样的地狱，以报那些因抑郁和虐待死去的同伴们的在天之灵。”";
    private List<string> BaoZhiL = new List<string>();
    private void Awake()
    {
        Debug.Log("Dialogue content is awake");
        ChuFaDanL.Add(ChuFaDan1);
        ChuFaDanL.Add(ChuFaDan2);

        TongZhiShuL.Add(TongZhiShu1);
        TongZhiShuL.Add(TongZhiShu2);

        XiaoDaoL.Add(XiaoDao1);
        XiaoDaoL.Add(XiaoDao2);

        XiaoGuiL.Add(XiaoGui1);
        XiaoGuiL.Add(XiaoGui2);

        SuiPianL.Add(SuiPian1);
        SuiPianL.Add(SuiPian2);

        BaoZhiL.Add(BaoZhi1);
        BaoZhiL.Add(BaoZhi2);

        Debug.Log(ChuFaDanL.Count);
    }

    public List<string> getChuFaDan(){return ChuFaDanL;}
    public List<string> getTongZhiShu() { return TongZhiShuL; }
    public List<string> getXiaoDao() { return XiaoDaoL; }
    public List<string> getXiaoGui() { return XiaoGuiL; }
    public List<string> getSuipian() { return SuiPianL; }
    public List<string> getBaoZhi() { return BaoZhiL; }

}
