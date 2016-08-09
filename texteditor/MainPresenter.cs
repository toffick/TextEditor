using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using texteditor.BL;



namespace texteditor.BL
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly DfEditor.IMessageService _messageService;
        private string _currentFilePath;
        public MainPresenter(IMainForm view, IFileManager manager, DfEditor.IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService=messageService;


            _view.SetSymbolCount(0);

            _view.ContentChanged +=new EventHandler(_view_ContentChanged);
            _view.FileOpenClick +=new EventHandler( _view_FileOpenClick);
            _view.FileSaveclick +=new EventHandler( _view_FileSaveclick);
        }

        private void _view_FileSaveclick(object sender, EventArgs e)
        {
            try
            {
                string content = _view.Content;
                _manager.SaveContent(content, _currentFilePath);
                _messageService.ShowMessage("Файл успешно сохранен");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;

                bool isExist = _manager.IsExist(filePath);

                if (!isExist)
                {
                    _messageService.ShowExclamation("Выбранный файл не существует");
                    return;
                }

                _currentFilePath = filePath;

                string content = _manager.GetContent(filePath);
                int count = _manager.GetSymbolCount(content);
                _view.Content = content;
                _view.SetSymbolCount(count);
            }
            catch(Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_ContentChanged(object sender, EventArgs e)
        {
            string content = _view.Content;

            int count = _manager.GetSymbolCount(content);

            _view.SetSymbolCount(count);
        }
    }
}
