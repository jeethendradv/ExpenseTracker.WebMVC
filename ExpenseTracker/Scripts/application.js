$(function () {
    $(".controlgroup").controlgroup();
    $("#transactionDate").datepicker({ dateFormat: 'dd-mm-yy' });
    $(".addCategory").click(function () {
        resetDialog();      
        $("#addCategory").dialog({
            modal: true
        });
    });

    $("#fileupload").click(function () {
        $("#TransactionReceipts").click();
    });

    $("#TransactionReceipts").change(function (event) {
        //clearRemovefileEvents();
        var length = event.target.files.length;
        var filenames = $("#fileNames");
        filenames.html("");
        for (var index = 0; index < length; index++) {
            var file = event.target.files[index];
            var fileNameTemplate = $('#fileLabelTemplate .fileNameTemplate').clone();
            fileNameTemplate.find(".filename").html(file.name);
            fileNameTemplate.find(".removeFile").attr("filename", file.name);
            filenames.append(fileNameTemplate);
        }
        //initialiseRemoveFileEvents();
    });

    $(".saveCategory").click(function () {
        $(".categoryrequirederror").addClass("hide");
        $(".categoryexistserror").addClass("hide");
        if (!isValidName()) {
            $(".categoryrequirederror").removeClass("hide");
            return;
        }
        checkNameExistsAndSave();
    });
    initialiseCalanderControl();

    function clearRemovefileEvents() {
        $(".removeFile").unbind("click");
    }

    function initialiseRemoveFileEvents() {
        $(".removeFile").click(function (event) {
            var filename = event.currentTarget.getAttribute("filename");
            // TODO: need to figure out how to remove the file from FileList object or convert the upload to AJAX.
        });
    }

    function resetDialog() {
        $("#newCategory").val("");
        $(".categoryrequirederror").addClass("hide");
        $(".categoryexistserror").addClass("hide");
    }

    function isValidName() {
        return $("#newCategory").val();        
    }

    function checkNameExistsAndSave() {
        var categoryName = $("#newCategory").val();
        $.ajax({
            method: "POST",
            url: "/Transaction/ValidateCategory",
            data: { name: categoryName }
        }).done(function (isValid) {
            if (isValid == "True") {
                saveCategory();
            }
            else {
                $(".categoryexistserror").removeClass("hide");
            }
        });
    }

    function saveCategory() {
        var categoryName = $("#newCategory").val();
        $.ajax({
            method: "POST",
            url: "/Transaction/AddCategory",
            data: { name: categoryName }
        }).done(function (exists) {
            fetchCategories();
        });
    }

    function fetchCategories() {
        $.ajax({
            method: "GET",
            url: "/Transaction/FetchCategories"
        }).done(function (categories) {
            $(".allcategories").html(categories);
            $("#addCategory").dialog("close");
        });
    }

    function initialiseCalanderControl() {
        $("#previousTrans").click(onPreviousClick);
        $("#nextTrans").click(onNextClick);
        $("input[name='expensePeriod']").click(calendarClick);
        updateCalendarText();
    }

    function calendarClick() {
        var period = $("input[name='expensePeriod']:checked").val();
        var date = new Date();
        switch (period) {
            case "1":
                updateWeekTransactions(date);
                break;
            case "2":
                updateMonthTransactions(date);
                break;
            case "3":
                updateYearTransactions(date);
                break;
        }
    }

    function onPreviousClick() {
        updateCalander(false);
    }

    function onNextClick() {
        updateCalander(true);
    }

    function updateCalander(isNext) {
        var period = $("input[name='expensePeriod']:checked").val();
        var date = fetchNextCalculationDate(isNext);
        switch (period) {
            case "1":
                updateWeekTransactions(date);
                break;
            case "2":
                updateMonthTransactions(date);
                break;
            case "3":
                updateYearTransactions(date);
                break;
        }
    }
    
    function fetchNextCalculationDate(isNext) {
        var date;
        if (isNext) {
            var d = getEndDate();
            d.setDate(d.getDate() + 1);
            date = d;
        } else {
            var d = getStartDate();
            d.setDate(d.getDate() - 1);
            date = d;
        }
        return date;
    }

    function updateWeekTransactions(date) {
        var weekStartDate = getFirstDayOfTheWeek(date);
        var weekEndDate = getLastDayOfTheWeek(date);
        updateAndFetchTransactions(weekStartDate, weekEndDate);
    }

    function updateYearTransactions(date) {
        var yearStartDate = getYearStartDate(date);
        var yearLastDate = getYearLastDate(date);
        updateAndFetchTransactions(yearStartDate, yearLastDate);
    }

    function updateMonthTransactions(date) {
        var monthStartDate = getMonthStartDate(date);
        var monthEndDate = getMonthLastDate(date);
        updateAndFetchTransactions(monthStartDate, monthEndDate);
    }

    function updateAndFetchTransactions(startdate, enddate) {
        updateStartDate(getFormatedDate(startdate));
        updateEndDate(getFormatedDate(enddate));
        updateCalendarText();
        fetchTransactions();
    }

    function fetchTransactions() {
        var startdate = $.format.date(new Date($("#startDate").val()), "dd-MM-yyyy");
        var enddate = $.format.date(new Date($("#endDate").val()), "dd-MM-yyyy");
        var period = $("input[name='expensePeriod']:checked").val();
        $.ajax({
            method: "POST",
            url: "/Home/FetchTransactions",
            data: { searchCriteria: { StartDate: startdate, EndDate: enddate, SearchPeriod: period }}
        }).done(function (html) {
            $(".transactions").html(html);
            var totalExpense = $("#totalExpHidden").val();
            $("#totalExpLabel").html("Total Expenses: $" + totalExpense);
        });
    }

    function updateCalendarText() {
        var period = $("input[name='expensePeriod']:checked").val();
        switch (period) {
            case "1":
                var startdate = getDateAndMonth(getStartDate());
                var enddate = getDateAndMonth(getEndDate());
                updateText(startdate + " - " + enddate);
                break;
            case "2":
                updateText(getMonthName(getStartDate()));
                break;
            case "3":
                updateText(getYear(getStartDate()));
                break;
        }
    }

    function updateText(text) {
        $("#transactionPeriod").html(text);
    }

    function getStartDate() {
        return new Date($("#startDate").val());
    }

    function getEndDate() {
        return new Date($("#endDate").val());
    }

    function updateStartDate(date) {
        $("#startDate").val(date);
    }

    function updateEndDate(date) {
        $("#endDate").val(date);
    }

    function getFirstDayOfTheWeek(date) {
        date = new Date(date);
        var day = date.getDay(),
            diff = date.getDate() - day + (day == 0 ? -6 : 1); // adjust when day is sunday
        return new Date(date.setDate(diff));
    }

    function getLastDayOfTheWeek(date) {
        date = getFirstDayOfTheWeek(date);
        date.setDate(date.getDate() + 6);
        return date;
    }

    function getMonthStartDate(date) {
        return new Date(date.getFullYear(), date.getMonth(), 1);
    }

    function getMonthLastDate(date) {
        return new Date(date.getFullYear(), date.getMonth() + 1, 0);
    }

    function getYearStartDate(date) {
        return new Date(date.getFullYear(), 0, 1);
    }

    function getYearLastDate(date) {
        return new Date(date.getFullYear(), 11, 31);
    }

    function getFormatedDate(date) {
        return $.format.date(date, "MM/dd/yyyy");
    }

    function getDateAndMonth(date) {
        return $.format.date(date, "dd MMM");
    }

    function getMonthName(date) {
        return $.format.date(date, "MMMM");
    }

    function getYear(date) {
        return $.format.date(date, "yyyy");
    }
});