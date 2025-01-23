using Luban.CodeTarget;
using Luban.CSharp.CodeTarget;
using Luban.CSharp.TemplateExtensions;
using Scriban;

namespace Luban.LazyLoad;

[CodeTarget("cs-lazyload-bin")]
public class CsharpLazyLoadBinCodeTarget : CsharpCodeTargetBase
{
    protected override void OnCreateTemplateContext(TemplateContext ctx)
    {
        base.OnCreateTemplateContext(ctx);
        ctx.PushGlobal(new CsharpBinTemplateExtension());
    }
}