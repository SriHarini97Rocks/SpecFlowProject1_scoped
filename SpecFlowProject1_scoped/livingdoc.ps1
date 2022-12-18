$date=(Get-Date).ToString("ddMMyyyyHHmmss")
$name="TestExecutionReport"+$date+".html"
$title="SpecFlow with TeamCity"
livingdoc test-assembly SpecFlowProject1_scoped\bin\Debug\net6.0\SpecFlowProject1_scoped.dll --test-execution-json SpecFlowProject1_scoped\bin\Debug\net6.0\TestExecution.json --output-type HTML --output $name --title $title