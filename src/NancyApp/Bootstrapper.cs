
namespace NancyApp
{
    public class Bootstrapper : Nancy.DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            // View�p�t�@�C�����܂܂��f�B���N�g���Ƃ��āAViews�f�B���N�g��������悤�ɒǉ�
            this.Conventions.ViewLocationConventions.Add((viewName, model, context) =>
            {
                return string.Concat("bin/Views/", viewName);
            });

            // �f�o�b�O�p�ɁA�G���[������������View�ɕ\������
            Nancy.StaticConfiguration.DisableErrorTraces = false;
        }
    }
}
