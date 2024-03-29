﻿import config from './config';
import * as Utils from './utils';

describe('ORGANIZATIONUNIT', () => {
    afterAll(async () => {
        await page.close();
    });

    afterEach(async () => {
        await Utils.wait(1000);
    });

    beforeAll(async () => {
        const login = new Utils.Login(config);
        await login.login();
    });

    describe('CRUD', () => {
        const ORGANIZATIONUNIT_CRUD_LIST = 'organizationunit.crud.010-list';
        const ORGANIZATIONUNIT_CRUD_NEW_MODAL = 'organizationunit.crud.020-new-modal';
        const ORGANIZATIONUNIT_CRUD_VALIDATION_SHOW = 'organizationunit.crud.030-validation-show';
        const ORGANIZATIONUNIT_CRUD_VALIDATION_HIDE = 'organizationunit.crud.040-validation-hide';
        const ORGANIZATIONUNIT_CRUD_NEW_SAVE = 'organizationunit.crud.050-new-save';
        const ORGANIZATIONUNIT_CRUD_ALREADY_EXISTED = 'organizationunit.crud.060-already-existed';
        const ORGANIZATIONUNIT_CRUD_ACTIONS = 'organizationunit.crud.070-actions';
        const ORGANIZATIONUNIT_CRUD_EDIT_MODAL = 'organizationunit.crud.080-edit-modal';
        const ORGANIZATIONUNIT_CRUD_EDIT_SAVE = 'organizationunit.crud.090-edit-save';
        const ORGANIZATIONUNIT_CRUD_ADD_SUB_ORGANIZATION = 'organizationunit.crud.091-add-sub-organization';
        const ORGANIZATIONUNIT_CRUD_DELETE_WARNING = 'organizationunit.crud.100-delete-warning';
        const ORGANIZATIONUNIT_CRUD_DELETE_CANCEL = 'organizationunit.crud.110-delete-cancel';
        const ORGANIZATIONUNIT_CRUD_DELETE_CONFIRM = 'organizationunit.crud.120-delete-confirm';

        /* Step 1 */
        it('should render the initial list', async () => {
            await Utils.clickMenu('Administration', 'Organization Units');
            await Utils.wait(1000);

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_LIST);
            expect(shot).toHaveNoChanges();
        });

        /* Step 2 */
        it('should display modal on click to "Add root unit" button', async () => {
            await Utils.clickByTextExact('Add root unit');
            await Utils.waitForModal('createOrEditModal');

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_NEW_MODAL);
            expect(shot).toHaveNoChanges();
        });

        /* Step 3 */
        it('should show error when form is saved before required inputs are filled', async () => {
            await triggerValidation();

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_VALIDATION_SHOW);
            expect(shot).toHaveNoChanges();
        });

        /* Step 4 */
        it('should hide error when form is properly filled', async () => {
            await fillInputsWithValidValues();
            await Utils.triggerValidation('#OrganizationUnitDisplayName');

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_VALIDATION_HIDE);
            expect(shot).toHaveNoChanges();
        });

        /* Step 5 */
        it('should save record when "Save" button is clicked', async () => {
            await Utils.saveForm();
            await Utils.waitForResponse();

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_NEW_SAVE);
            expect(shot).toHaveNoChanges();
        });

        /* Step 6 */
        it('should give an error when trying to create an existing item', async () => {
            await Utils.clickByTextExact('Add root unit');
            await Utils.waitForModal('createOrEditModal');

            await fillInputsWithValidValues();

            await Utils.saveForm();
            await Utils.waitForResponse();

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_ALREADY_EXISTED);
            expect(shot).toHaveNoChanges();
        });

        /* Step 7 */
        it('should display actions on click to "Actions" button', async () => {
            await Utils.confirmConfirmation();
            await Utils.clickButtonByText('Cancel');
            await openOUDropdown();

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_ACTIONS);
            expect(shot).toHaveNoChanges();
        });

        /* Step 8 */
        it('should display modal on click to "Edit" button', async () => {
            await clickOUDropdown('Edit');

            await Utils.waitForModal('createOrEditModal');

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_EDIT_MODAL);
            expect(shot).toHaveNoChanges();
        });

        /* Step 9 */
        it('should save changes to record when "Save" button is clicked', async () => {
            await Utils.fillInputs({ '#OrganizationUnitDisplayName': 'changed_name' });
            await Utils.saveForm();
            await Utils.waitForResponse();

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_EDIT_SAVE);
            expect(shot).toHaveNoChanges();
        });

        /* Step 10 */
        it('should add sub organization', async () => {
            await openOUDropdown();
            await Utils.clickByText('Add sub-unit');
            await Utils.fillInputs({ '#OrganizationUnitDisplayName': 'test-sub-unit' });
            await Utils.saveForm();
            await Utils.waitForResponse();
            await page.waitForSelector('.pi-chevron-right');
            await page.click('.pi-chevron-right')
            await Utils.wait(500);

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_ADD_SUB_ORGANIZATION);
            expect(shot).toHaveNoChanges();
        });

        /* Step 11 */
        it('should display warning on click to "Delete" button', async () => {
            await openOUDropdown();
            await Utils.clickByTextWithin(".p-contextmenu",'Delete');
            await Utils.waitForConfirmationDialog();

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_DELETE_WARNING);
            expect(shot).toHaveNoChanges();
        });

        /* Step 12 */
        it('should not delete record on click to "Cancel" button', async () => {
            await Utils.cancelConfirmation();
            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_DELETE_CANCEL);
            expect(shot).toHaveNoChanges();
        });

        /* Step 13 */
        it('should delete record on click to "Yes" button', async () => {
            await openOUDropdown();
            await Utils.clickByTextWithin(".p-contextmenu",'Delete');

            await Utils.waitForConfirmationDialog();
            await Utils.confirmConfirmation();
            await Utils.waitForResponse();

            const shot = await Utils.screenshot.test(ORGANIZATIONUNIT_CRUD_DELETE_CONFIRM);
            expect(shot).toHaveNoChanges();
        });

        async function triggerValidation() {
            await fillInputsWithValidValues();
            await Utils.clearInputs('#OrganizationUnitDisplayName');
        }

        function fillInputsWithValidValues() {
            return Utils.fillInputs({
                '#OrganizationUnitDisplayName': 'test'
            });
        }

        async function openOUDropdown() {
            await page.click('ul[role=tree] div[role=treeitem]', { button: 'right' });
            await page.waitForSelector('.p-contextmenu ', { state: 'visible' });
        }

        function clickOUDropdown(text: string) {
            return page.click(`css=.p-menuitem-link >> text=/.*${text}.*/`);
        }
    });
});