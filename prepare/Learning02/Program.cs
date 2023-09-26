Job job1 = new()
{
    _startYear = 2014,
    _endYear = 2017,
    _company = "Microsoft",
    _jobTitle = "Software Developer"
};

Job job2 = new()
{
    _startYear = 2017,
    _endYear = 2024,
    _company = "Apple",
    _jobTitle = "Manager"
};

Resume myResume = new()
{
    _name = "Elijah Foard"
};

myResume._jobs.Add(job1);
myResume._jobs.Add(job2);
myResume.Display();
