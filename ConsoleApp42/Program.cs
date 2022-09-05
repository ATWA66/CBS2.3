Console.WriteLine("enter your acces key or skip it(key is(1 for pro & 2 for expert))");
if (Console.ReadLine() == "1")
{
    DocumentWorker example = new ProDocumentWorker();
    example.SaveDocument();
}
else if (Console.ReadLine() == "2")
{
    DocumentWorker example = new ExpertDocumentWorker();
    example.SaveDocument();
}
else
{
    DocumentWorker example = new DocumentWorker();
    example.SaveDocument();
}
class DocumentWorker
{
    virtual public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    virtual public void EditDocument()
    {
        Console.WriteLine("Редактирование документа в версии О");
    }
    virtual public void SaveDocument()
    {
        Console.WriteLine("Сохранение документа в версии О");
    }

}
class ProDocumentWorker : DocumentWorker
{
    override public void OpenDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    override public void EditDocument()
    {
        Console.WriteLine("Редактирование документа в версии О");
    }
    override public void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт");
    }
}
class ExpertDocumentWorker : ProDocumentWorker 
{
    override public void OpenDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    override public void EditDocument()
    {
        Console.WriteLine("Редактирование документа в версии О");
    }
    override public void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в new формате");
    }
}
