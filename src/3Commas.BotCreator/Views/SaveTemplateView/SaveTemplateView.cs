using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _3Commas.BotCreator.Services.BotSettingService;
using _3Commas.BotCreator.Services.MessageBoxService;
using _3Commas.BotCreator.Views.MainForm;
using AutoMapper;

namespace _3Commas.BotCreator.Views.SaveTemplateView
{
    public partial class SaveTemplateView : Form
    {
        private readonly IBotSettingService _templateService;
        private BotSettingViewModel _botSettings;
        private readonly IMessageBoxService _mbs = new MessageBoxService();
        private readonly IMapper _mapper;

        public SaveTemplateView(IBotSettingService templateService, IMapper mapper)
        {
            _mapper = mapper;
            _templateService = templateService;
            InitializeComponent();

            cmbExistingTemplate.DisplayMember = nameof(BotSettings.Name);
            cmbExistingTemplate.ValueMember = nameof(BotSettings.Id);
            cmbExistingTemplate.DataSource = _templateService.GetAll();
        }

        public void Init(BotSettingViewModel settings)
        {
            _botSettings = settings;
        }

        private void radioButtonCreateNew_CheckedChanged(object sender, EventArgs e)
        {
            txtNewTemplate.Visible = sender == radioButtonCreateNew;
            cmbExistingTemplate.Visible = sender == radioButtonOverwriteExisting;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                bool result = false;

                var settings = _mapper.Map<BotSettingViewModel, BotSettings>(_botSettings);

                if (radioButtonCreateNew.Checked)
                {
                    result = _templateService.Insert(settings, txtNewTemplate.Text);
                }
                if (radioButtonOverwriteExisting.Checked)
                {
                    result = _templateService.Update(settings, (Guid)cmbExistingTemplate.SelectedValue);
                }

                if (!result)
                {
                    _mbs.ShowError("An error occured while saving the bot settings");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private bool IsValid()
        {
            var errors = new List<string>();

            if (!radioButtonCreateNew.Checked && !radioButtonOverwriteExisting.Checked) errors.Add("Please select an option");
            if (radioButtonCreateNew.Checked && string.IsNullOrWhiteSpace(txtNewTemplate.Text)) errors.Add("Please specify a name for the new Template");
            if (radioButtonCreateNew.Checked && cmbExistingTemplate.Items.Cast<BotSettings>().Any(x => x.Name == txtNewTemplate.Text)) errors.Add("This name is already in use");
            if (radioButtonOverwriteExisting.Checked && cmbExistingTemplate.SelectedItem == null) errors.Add("Existing Template not selected");

            if (errors.Any())
            {
                _mbs.ShowError(String.Join(Environment.NewLine, errors), "Validation Error");
            }

            return !errors.Any();
        }
    }
}
