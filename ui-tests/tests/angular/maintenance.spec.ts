﻿import config from './config';
import * as Utils from './utils';

describe('MAINTENANCE', () => {
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

    describe('CODE FLOW', () => {
        const MAINTENANCE_PAGE_RENDER = 'maintenance.code-flow.page-render';
        const MAINTENANCE_CLEAR_ALL_CACHES = 'maintenance.code-flow.clear-all-caches';

        /* Step 1 */
        it('should render the page', async () => {
            await Utils.clickMenu('Administration', 'Maintenance');
            await Utils.wait(1000);

            const shot = await Utils.screenshot.test(MAINTENANCE_PAGE_RENDER);
            expect(shot).toHaveNoChanges();
        });
    });
});